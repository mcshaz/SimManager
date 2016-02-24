﻿(function () {
    'use strict';
    var serviceBase = 'https://localhost:44300/'; // change to production host
    var app = angular.module('app', [
        // Angular modules 
        'ngAnimate',        // animations
        'ngRoute',          // routing
        'ngSanitize',       // sanitizes html bindings (ex: sidebar.js)

        // Custom modules 
        'common',           // common functions, logger, spinner
 //       'ui.router', 
        'http-auth-interceptor', 
        'LocalStorageModule',

        // 3rd Party Modules
        'ui.bootstrap',      // ui-bootstrap (ex: carousel, pagination, dialog)
        'breeze.angular'
    ]);

    /*Constants regarding user login defined here*/
    app.constant('USER_ROLES', {
            all: '*',
            siteAdmin: 'siteAdmin',
            institutionAdmin: 'institutionAdmin',
            faculty: 'faculty',
            participant: 'participant'
    })
        .constant('AUTH_EVENTS', {
            forbidden: 'event:auth-forbidden',
            loginRequired: 'event:auth-loginRequired',
            loginConfirmed: 'event:auth-loginConfirmed',
            loginCancelled: 'event:auth-loginCancelled'
        })
        .config(['localStorageServiceProvider', function (localStorageServiceProvider) {
            localStorageServiceProvider
                .setPrefix('loginApp')
                .setStorageType('sessionStorage');
        }])
        .constant('ngAuthSettings', {
            apiServiceBaseUri: serviceBase,
            clientId: 'simmanager'
        });
    // Handle routing errors and success events
    app.run(['$route', function ($route) {
        // Include $route to kick start the router.
    }]);
})();
//polyfill https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/find
if (!Array.prototype.find) {
    Array.prototype.find = function (predicate) {
        if (this === null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}