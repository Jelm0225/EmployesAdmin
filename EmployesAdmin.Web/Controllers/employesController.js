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


            $scope.Employe = {

                GetEmployesList: function () {

                    //employeService.getEmployes($scope.Id, function (data) {


                    //    alert('Consumido');
                    //    //if (data.Exito) {

                    //    //    $scope.ListaClientes = data.Resultado;

                    //    //} else {

                    //    //    alert('Error al Cargar el Listado de Clientes.' + data.Mensaje);

                    //    //}

                    //});
                },
            }


            $scope.CleanValues = function () {

                $scope.Id = null;

            }


            $scope.init = function () {

                $scope.CleanValues();

                $scope.Employe.GetEmployesList();

            };

            $scope.init();

        }]);

}());