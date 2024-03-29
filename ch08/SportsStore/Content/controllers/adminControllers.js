﻿angular.module("sportsStoreAdmin")
	.constant("authUrl", "http://localhost:5500/users/login")
	.constant("ordersUrl", "http://localhost:5500/orders")
	.controller("authCtrl", function ($scope, $http, $location, authUrl) {
		console.log("authCtrl initializing");
		$scope.authenticate = function (user, pass) {
			$http.post(authUrl, {
				username: user,
				password: pass
			},
				{
					withCredentials: true
				})
				.success(function (data) {
					$location.path("/main")
				})

				.error(function (error) {
					$scope.authenticationError = error;
				});
		}
	})
	.controller("mainCtrl", function ($scope) {
		$scope.screens = ["Products", "Orders"];
		$scope.current = $scope.screens[0];

		$scope.setScreen = function (index) {
			$scope.current = $scope.screens[index];
		}

		$scope.getScreen = function () {
			return $scope.current == "Products" ?
				"/Content/views/adminProducts.html" : "/Content/views/adminOrders.html";
		}
	})
	.controller("ordersCtrl", function ($scope, $http, ordersUrl) {

		$http.get(ordersUrl, { withCredentials: true })
			.success(function (data) {
				$scope.orders = data;
			})
			.error(function (error) {
				$scope.error = error;
			});

		$scope.selectedOrder;

		$scope.selectOrder = function (order) {
			$scope.selectedOrder = order;
		}

		$scope.calcTotal = function (order) {
			let total = 0;
			for (let product of order.products) {
				total += product.count * product.price;
			}
			return total;
		}
	});