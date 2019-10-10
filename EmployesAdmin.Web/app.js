(function () {

    'use strict';

    angular.module('employeAdmin', [
        'ngRoute',
        'ngCookies']).config([
            '$routeProvider',

            function ($routeProvider) {

                $routeProvider.when('/', {
                    templateUrl: 'Templates/employesTemplate.html',
                    controller: 'employesController'
                });

            }]);

}());