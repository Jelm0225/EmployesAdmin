(function () {

    'use strict';

    angular.module('employeAdmin').controller('employesController', [

        '$scope',
        '$rootScope',
        '$location',
        'employeService',
        function ($scope,
            $rootScope,
            $location,
            employeService) {

            $scope.Id = null;
            $scope.Valor = 100000;
            $scope.EmployeList = [];


            $scope.Employe = {

                GetEmployesList: function () {

                    $scope.EmployeList = [];

                    employeService.getEmployes($scope.Id, function (data) {

                        if (data) {
                            $scope.EmployeList = data;
                        }

                    });
                }
            };

            $scope.CleanValues = function () {

                $scope.Id = null;

            };

            $scope.init = function () {

                $scope.CleanValues();

                $scope.Employe.GetEmployesList();

            };

            $scope.init();

        }]);

}());