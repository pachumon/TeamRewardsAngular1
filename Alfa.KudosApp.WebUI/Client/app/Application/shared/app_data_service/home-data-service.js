(function () {
    'use strict';

    app.service('homeDataService', homeDataService);

    homeDataService.$inject = ['$http', '$log', '$q'];
    function homeDataService($http, $log, $q) {
        this.GetHomeInitialData = GetHomeInitialData;



        function GetHomeInitialData() {
            return $http({ method: 'GET', url: 'homeapi/RetrieveInitialDatas' }).
                then(function successcb(response, status, headers, config) {
                    $log.info(response.data);
                    return response;
                }).
                catch(function errorcb(response, status, headers, config) {
                    var val = $q.reject(response);
                    $log.info(val);
                    return val;
                });



        }
    }
})();