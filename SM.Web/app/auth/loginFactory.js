(function(){
    'use strict';
    var serviceId = 'loginFactory';
    angular.module('app')
        .factory(serviceId, ['$http', '$httpParamSerializerJQLike', 'tokenStorageService', 'common',loginFactory]);

    function loginFactory($http, $httpParamSerializerJQLike, tokenStorageService, common) {
        var log = common.logger.getLogFn(serviceId);
        var service = {
            login : login, 
            logout: logout,
            registerExternal: registerExternal
        }
	
        return service;
	
        function login(credentials) {
            var loginData = {
                grant_type: 'password',
                username: credentials.username,
                password: credentials.password
            };
            return $http({
                            method:'POST',
                            url:'/Token', 
                            data:$httpParamSerializerJQLike(loginData), // Make sure to inject the service you choose to the controller
                            headers: {
                                'Content-Type': 'application/x-www-form-urlencoded' // Note the appropriate header
                            }
            }).then(function (response) {
                tokenStorageService.notifyLogin(response.data);
                return response.data;
            });
        }

        function logout() {
            if (tokenStorageService.isLoggedIn()) {
                $http({
                    method: 'POST',
                    url: 'api/Account/Logout',
                    ignoreAuthModule: true // if we had already timed out, a 401 will be returned
                }).then(function (response) {
                    tokenStorageService.notifyLogout(response);
                    log.success({ msg: 'logged out' });
                }, function (response) {
                    log.warn({ msg: 'Logout failed', data: response });
                });
            } else {
                log.debug({ msg: 'logout called - Not logged in' });
            }
        };

	    function registerExternal(registerExternalData) {
	        authService.loginConfirmed(registerExternalData);
	    };

    };
})();