angular.module('ticketify')
    .controller('ModalController', ModalController);

ModalController.$inject = ['$scope', '$uibModalInstance', 'answer', 'params'];

// Controller function that works inside the modal. 
// items should come from the calling controller i.e the controller that starts the modal. 
function ModalController($scope, $uibModalInstance, answer, params) {

    $scope.answer = answer;
    $scope.params = params;


    $scope.proceed = function () {
        $scope.answer = true; 
        $uibModalInstance.close($scope.answer);
    };

    $scope.close = function () {
        $uibModalInstance.dismiss('cancel');
    };

}