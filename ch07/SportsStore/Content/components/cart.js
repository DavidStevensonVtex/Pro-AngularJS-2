angular.module("cart")
	.factory("cart", function () {

		let cartData = [];

		return {
			addProduct: function (id, name, price) {
				let addedToExistingItem = false;
				for (let item of cardData) {
					if (item.id == id) {
						item.count++;
						addedToExistingItem = true;
						break;
					}
				}

				if (!addedToExistingItem) {
					cartData.push({
						count: 1, id: id, price: price, name: name
					});
				}
			},

			removeProduct: function (id) {
				for (let i = 0; i < cartData.length; i++) {
					if (cartData[i].id == id) {
						cartData.splice(i, 1);
					}
				}
			},

			getProducts: function () {
				return cartData;
			}
		}
	});