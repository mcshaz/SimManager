﻿(function () {
    'use strict';

    var app = angular.module('app');

    var userRoles = {
        all: '*',
        siteAdmin: 'siteAdmin',
        institutionAdmin: 'institutionAdmin',
        faculty: 'faculty',
        participant: 'participant'
    };

    // Collect the routes
    app.constant('USER_ROLES', userRoles)
        .constant('routes', getRoutes());
    
    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {

        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });
    }

    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/dashboard/dashboard.html',
                    title: 'dashboard',
                    settings: {
                        nav: 1,
                        content: '<i class="fa fa-dashboard"></i> Dashboard'
                    }
                }
            }, {
                url: '/admin',
                config: {
                    title: 'admin',
                    templateUrl: 'app/admin/admin.html',
                    settings: {
                        nav: 2,
                        content: '<i class="fa fa-lock"></i> Admin'
                    },
                    access: {
                        allowedRoles: userRoles.siteAdmin
                    }
                }
            }, {
                url: '/course/:id',
                config: {
                    title: 'course',
                    templateUrl: 'app/course/course.html',
                    settings: {
                        nav: 3,
                        content: 'Course' //<i class="fa fa-"></i> 
                    },
                    access: {
                        allowedRoles: userRoles.all
                    }
                }
            }, {
                url: '/courseTypes',
                config: {
                    title: 'Course Types',
                    templateUrl: 'app/courseTypes/courseTypes.html',
                    settings: {
                        nav: 4,
                        content: 'Course Types' //<i class="fa fa-"></i> 
                    },
                    access: {
                        allowedRoles: userRoles.all
                    }
                }
            }, {
                url: '/courseFormat/:id',
                config: {
                    title: 'Course Format',
                    templateUrl: 'app/courseFormat/courseFormat.html',
                    settings: {
                        nav: 5,
                        content: 'Course Format' //<i class="fa fa-"></i> 
                    },
                    access: {
                        allowedRoles: userRoles.all
                    }
                }
            }
        ];
    }
})();