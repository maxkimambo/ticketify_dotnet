'use strict';

angular.module('ticketify')
    .controller('SetupModalController', SetupModalController);

SetupModalController.$inject = ['$scope', '$uibModal', 'setupData', 'toasterService'];

function SetupModalController($scope, $uibModal, setupData, toast) {

    $scope.busses = setupData.busses; 

    var params = {
        modalHeader: 'Notification',
        modalBody: 'Are you sure you want to delete this item'

    }


    $scope.params = params;
    $scope.answer = false;

    $scope.remove = function(bus) {

        $scope.params.modalBody = "Are you sure you want to delete this item " + bus.number;

        var modalInstance = $uibModal.open({
            animation: true,
            templateUrl: 'setupModal.html',
            controller: 'ModalController',
            size: 'lg',
            resolve: {
                params: $scope.params,
                answer: function() {
                    return $scope.answer;
                }
            }
        });

        modalInstance.result.then(function(answer) {
          if (answer) {
              removeBus(bus); 
           }

        }, function() {
            //$log.info('Modal dismissed at: ' + new Date());
        });

    }


    function removeBus(bus) {

        var indx = $scope.busses.indexOf(bus);
       $scope.busses.splice(indx, 1);
        toast.success('Bus removed');
    };

    $scope.edit = function (bus) {

        $scope.params.modalHeader = "Edit item";
        $scope.params.modalBody = bus.number;

        var modalInstance = $uibModal.open({
            animation: true,
            templateUrl: 'setupModal.html',
            controller: 'ModalController',
            size: 'lg',
            resolve: {
                params: $scope.params,
                answer: function () {
                    return $scope.answer;
                }
            }
        });

        modalInstance.result.then(function (answer) {
            $scope.selected = answer;
           
        }, function () {
            //$log.info('Modal dismissed at: ' + new Date());
        });
    }

   
}