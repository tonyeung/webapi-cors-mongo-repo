'use strict';

var app = angular.module('app', []);
app.config(['$httpProvider', '$routeProvider', function ($httpProvider, $routeProvider) {

        $httpProvider.defaults.useXDomain = true;
        delete $httpProvider.defaults.headers.common['X-Requested-With'];

}]);
