(function () {
    'use strict';

    angular
        .module('lApp', [])
        .controller('extC', extCont);

    extCont.$inject = ['$scope']; 

    function extCont($scope) {
        $scope.title = 'External Controller Files need \'[]\' adding';

        activate($scope);

        f($scope);

        function activate($scope) {
            $scope.something = 'Somewhere over the rainbow!!!!!';

        }
    }

    function f ($scope) {
        $scope.noway = 'Not a chance...';
    }
})();
