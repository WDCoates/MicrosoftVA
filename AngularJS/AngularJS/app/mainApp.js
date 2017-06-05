/*Some Comments*/

var mainApp = angular.module('mainApp', [])
    .config([function () {
        /**/
        console.log("Config fun!");
    }])

    .run([function () {
        /**/
        console.log(".run Fun!");
    }])
    
    .run(function ($rootScope) {
        $rootScope.rTest = " - More Run Fun!";
    })
;
