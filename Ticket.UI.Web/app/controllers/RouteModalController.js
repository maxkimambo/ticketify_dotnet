angular.module('ticketify')
    .controller('RouteModalController', RouteModalController);

RouteModalController.$inject = ['$scope', '$uibModalInstance', 'routeData'];

// Controller function that works inside the modal. 
// items should come from the calling controller i.e the controller that starts the modal. 
function RouteModalController($scope, $uibModalInstance,  routeData) {

    $scope.routeData = routeData;

    $scope.proceed = function () {
        $uibModalInstance.close($scope.routeData);
        $scope.routeData = null; 
    };

    $scope.close = function () {
        $uibModalInstance.dismiss('cancel');
    };

}