'use strict';

angular.module('ticketify')
    .controller('SetupModalController', SetupModalController);

SetupModalController.$inject = ['$scope', '$uibModal'];

function SetupModalController($scope, $uibModal) {

    var params = {
        modalHeader: 'Notification',
        modalBody: 'Are you sure you want to delete this item'

    }


    $scope.params = params;
    $scope.answer = false; 
    $scope.open = function () {

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