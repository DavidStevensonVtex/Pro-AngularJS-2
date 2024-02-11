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