(function () {

    'use strict';

    angular.module('employeAdmin').factory('employeService', ['$http',
        function ($http) {

            var employeService = {};

            employeService.getEmployes = function (id, cb) {

                var svcURIlang = '';

                if (id == undefined || id == null || id == '') {
                     svcURIlang = 'https://localhost:44325/api/Values/Get';
                } else {
                    svcURIlang = 'https://localhost:44325/api/Values/Get?employeName=' + id;
                }

                console.log($http);

                $http({
                    method: 'GET',
                    url: svcURIlang
                }).then(function success(response) {
                    cb(response.data);
                });

            };

            return employeService;

        }]);

}());