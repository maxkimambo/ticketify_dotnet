angular.module('ticketify')
    .controller('BusModalController', BusModalController);

BusModalController.$inject = ['$scope', '$uibModalInstance', 'bus'];

// Controller function that works inside the modal. 
// items should come from the calling controller i.e the controller that starts the modal. 
function BusModalController($scope, $uibModalInstance, bus) {

    $scope.bus = bus;

    $scope.proceed = function () {
        $uibModalInstance.close($scope.bus);
        $scope.busses = null; 
    };

    $scope.close = function () {
        $uibModalInstance.dismiss('cancel');
    };

}