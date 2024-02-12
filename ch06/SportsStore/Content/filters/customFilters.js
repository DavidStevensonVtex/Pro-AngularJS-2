angular.module("customFilters", []) 
	.filter("unique", function () {
		return function (data, propertyName) {
			if (angular.isArray(data) && angular.isString(propertyName)) {
				let results = [];
				let keys = {};
				for (let item of data) {
					let val = item[propertyName];
					if (angular.isUndefined(keys[val])) {
						keys[val] = true;
						results.push(val);
					}
				}
				return results;
			} else {
				return data;
			}
		}
	})
	.filter("range", function ($filter) {
		return function (data, page, size) {
			if (angular.isArray(data) && angular.isNumber(page) && angular.isNumber(size)) {
				let start_index = (page - 1) * size;
				if (data.length < start_index) {
					return [];
				} else {
					return $filter("limitTo")(data.splice(start_index), size);
				}
			}
		}
	})
	.filter("pageCount", function () {
		return function (data, size) {
			if (angular.isArray(data)) {
				let result = [];
				for (let i = 0; i < Math.ceil(data.length / size); i++) {
					result.push(i);
				}
				return result;
			} else {
				erturn data;
			}
		}
	})