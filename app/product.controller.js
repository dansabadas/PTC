(function () {
  'use strict';
  angular.module('app').controller('ProductController', ProductController);

  function ProductController($http) {
    var vm = this;
    var dataService = $http;

    vm.products = [];
    vm.searchCategories = [];

    vm.searchInput = {
      selectedCategory: {
        CategoryId: 0,
        CategoryName: ''
      },
      productName: ''
    };
    vm.product = {
      ProductId: 1,
      ProductName: 'product some name'
    };

    productList();
    searchCategoriesList();

    function searchCategoriesList() {
      dataService.get('/api/Category/GetSearchCategories')
      .then(
        function (result) {
          vm.searchCategories = result.data;
          //debugger;
        },
        function (error) {
          handleException(error);
        });
    }

    function productList() {
      dataService.get('/api/Product')
      .then(
        function (result) {
          vm.products = result.data;
          //debugger;
        },
        function (error) {
          handleException(error);
      });
    }

    function handleException(error) {
      alert(error.data.ExceptionMessage);
    }
  }
})();