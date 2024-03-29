﻿angular.module("sportsStore")
	.constant("dataUrl", "http://localhost:5500/products")
	.controller("sportsStoreCtrl", function ($scope, $http, dataUrl) {
		$scope.data = {};

		$http.get(dataUrl)
			.success(function (data) {
				$scope.data.products = data;
			})
			.error(function (error) {
				console.log("error", error);
				$scope.data.error = error;
			});
	});