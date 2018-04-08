(function () {
    var app = angular.module("myApp", ['ngMask']);
    app.controller("FormController", function ($scope) {

        $scope.step = 1;
        $scope.nextStep = function (valid) {
            if (valid) {
                $scope.step++;
            }
        };

        $scope.prevStep = function () {
            $scope.step--;
        };
    });

})();