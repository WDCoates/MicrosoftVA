(function () {
    'use strict';

    angular
        .module('app', [])
        .controller('controller', controller)
        .controller('httpCont', httpC)
        .controller('ticker', tick)
        .service('hexer', function () {
            this.myFunc = function (x) {
                return x.toString(16);
            }
        })
        .filter('hexF', ['hexer', function (hexer) {
            return function (x) {
                return hexer.myFunc(x);
            };
        }])
        .controller('hexed', hexed)
    ;

    hexed.$inject = ['$scope', 'hexer'];
    function hexed($scope, hexer) {
        $scope.hexedRes = hexer.myFunc(255);
    };

    controller.$inject = ['$scope', '$location'];
    httpC.$inject = ['$scope', '$http', '$timeout'];

    function httpC($scope, $http, $timeout) {
        $http.get("Welcome.xml").then(function (response) {
            $scope.welMsg = response.data;

            $timeout(function () {
                $scope.welMsg = "This message had timed out!!!!";
            }, 4000);
                
        })

    };

    tick.$inject = ['$scope', '$interval'];
    function tick($scope, $interval) {
        $scope.countDown = 100;
        $interval(function () {
            $scope.countDown = $scope.countDown - 1;
        }, 1000);
    };

    function controller($scope, $location) {
        $scope.title = 'Working With Services';
        $scope.url = $location.$$absUrl;
        $scope.urlFf = $location.absUrl();
        $scope.locHost = $location.host();

        $scope.counts = [255, 251, 200];
    
        activate();
        function activate() { }
    }
})();
