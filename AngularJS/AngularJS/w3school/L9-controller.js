(function () {
    'use strict';

    angular
        .module('app', [])
        .controller('controller', controller)
        .filter('myF1', filter1)
        ;

    controller.$inject = ['$scope'];
    
    function filter1() {
        return function (name) {
            var txt = "A...";

            return txt;
        };
    };

    function controller($scope) {
        /* jshint validthis:true */
        $scope.title = 'Filter Controller what can we do with them...';
        $scope.names = [
        { name: 'Jani', country: 'Norway' },
        { name: 'Carl', country: 'Sweden' },
        { name: 'Margareth', country: 'England' },
        { name: 'Hege', country: 'Norway' },
        { name: 'Joe', country: 'Denmark' },
        { name: 'Gustav', country: 'Sweden' },
        { name: 'Birgit', country: 'Denmark' },
        { name: 'Mary', country: 'England' },
        { name: 'Kai', country: 'Norway' }
        ];

        $scope.users = ['Jani','Carl','Margareth','Hege','Joe','Gustav','Birgit','Mary','Kai'];

        $scope.orBy = function (x) {
            $scope.ord = x;
        }

        $scope.Price = 1122.44;

        activate();

        function activate() { };

        
    }
})();
