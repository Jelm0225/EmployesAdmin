(function () {

    'use strict';

    angular.module('employeAdmin').factory('employeService', ['$http',
        function ($http) {

            var employeService = {};

            employeService.getEmployes = function (id, cb) {
                var svcURIlang = 'https://localhost:44325/api/Values/Get';


                $http.post(svcURIlang, {
                    "Id": (id == null || id == undefined ? 0 : id)
                }).then(function (data) {
                    // With the data succesfully returned, call our callback
                    cb(data.data);
                });
            };

            return employeService;

        }]);

}());