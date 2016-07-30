(function () {
  'use strict';
  angular.module('app').controller('ProductController', ProductController);

  function ProductController($http) {
    var vm = this;
    var dataService = $http;

    vm.products = [];
    vm.product = {
      ProductId: 1,
      ProductName: 'product some name'
    };

    productList();

    function productList() {
      dataService.get('/api/Product')
      .then(
      function (result) {
        vm.products = result.data;
        debugger;
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