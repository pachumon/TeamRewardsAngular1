(function () {
    'use strict';

    app.component('home', {
        templateUrl: 'Client/App/Application/home/home.component.html',
        controllerAs: 'vm',
        controller: [
            'toastrService', '$scope', 'homeDataService', homeController
        ]
    });


    function homeController(toastrService, $scope, homeDataService) {
        var vm = this;
        vm.active = 0;
        vm.viewmodel = {};

        vm.$onInit = function () {
            vm.active = 2;
            homeDataService.GetHomeInitialData()
                .then(function (data) {
                    vm.viewmodel = data;
                })
                .catch(function (response) {
                    console.error(response);
                });

        }

        vm.clicked = function (index) {
            //toastrService.showSuccess("success");
            vm.active = index;

        };

    }
})();