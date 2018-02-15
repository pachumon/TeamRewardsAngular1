var app = angular.module("rewardsapp", [
    "ngRoute",
    "ngSanitize",
    "ngAnimate",
    "ui.bootstrap",
    "toastr"
]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider
        .when("/", {
            template: "<home></home>"
        })
        .otherwise({ redirectTo: "/" });
}
]);