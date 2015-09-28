(function () {
    'use strict';

    angular
        .module('uncleApp')
        .controller('addUpdateCustomer', ["$scope", function ($scope) {
            $scope.title = 'Add New Customer';
        }]);
})();
