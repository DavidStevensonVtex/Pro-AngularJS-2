﻿angular.module("sportsStore")
	.constant("productListActiveClass", "btn-primary")
	.constant("productListPageCount", 3)
	.controller("productListCtrl", function ($scope, $filter, productListActiveClass, productListPageCount) {

		let selectedCategory = null;

		$scope.selectedPage = 1;
		$scope.pageSize = productListPageCount;

		$scope.selectCategory = function (newCategory) {
			selectedCategory = newCategory;
			$scope.selectedPage = 1;
		}

		$scope.categoryFilterFn = function (product) {
			return selectedCategory == null ||
				product.category == selectedCategory;
		}

		$scope.getCategoryClass = function (category) {
			return selectedCategory == category ? productListActiveClass : "";
		}

		$scope.getPageClass = function (page) {
			return $scope.selectedPage == page ? productListActiveClass : "";
		}
	});