angular.module("sportsStore")
	.controller("productListCtrl", function ($scope, $filter) {

		let selectedCategory = null;

		$scope.selectCategor = function (newCategory) {
			selectedCategory = newCategory;
		}

		$scope.categoryFilterFn = function (product) {
			return selectedCategory == null ||
				product.category == selectedCategory;
		}
	});