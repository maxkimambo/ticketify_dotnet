'use strict';

angular.module('ticketify')
    .controller('SetupModalController', SetupModalController);

SetupModalController.$inject = ['$scope', '$uibModal', 'setupData', 'toasterService'];

function SetupModalController($scope, $uibModal, setupData, toast) {

    $scope.busses = setupData.busses;
    $scope.routes = setupData.routes;
    $scope.company = setupData.company;

    var params = {
        modalHeader: 'Notification',
        modalBody: 'Are you sure you want to delete this item ',
        proceedText: 'Yes Delete',
        cancelText: 'Cancel'
    }


    $scope.params = params;
    $scope.answer = false;

    $scope.remove = function(bus) {

        $scope.params.modalBody = "Are you sure you want to delete this item ?"; 

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
        $scope.params.proceedText = "Save";

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

    $scope.editRoute = function (route) {
        $scope.params.modalHeader = "Edit item";
        $scope.params.modalBody = "";
        $scope.params.proceedText = "Save";

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

    $scope.removeRoute = function (route) {

        $scope.params.modalBody = "Are you sure you want to delete this route ?";

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
          if (answer) {
              removeRoute(route); 
          }

        }, function () {
            //$log.info('Modal dismissed at: ' + new Date());
        });

       
    }
    
    function removeRoute(route) {
        //TODO send ajax request to get the route removed on the server side. 
        var indx = $scope.routes.indexOf(route);
        $scope.routes.splice(indx, 1);
        toast.success('Route removed');
    };

    $scope.addRoute = function () {
        var routeData = {}; 
        var modalInstance = $uibModal.open({
            animation: true,
            templateUrl: 'RoutesModal.html',
            controller: 'RouteModalController',
            size: 'lg',
            resolve: {
               routeData: function () {
                    return routeData;
                }
            }
        });

        modalInstance.result.then(function (dataFromModal) {
            console.log(dataFromModal);
            $scope.routes.push(dataFromModal); 
        }, function () {
            //$log.info('Modal dismissed at: ' + new Date());
        });

    }

    $scope.addBus = function () {
        var bus = {};
        var modalInstance = $uibModal.open({
            animation: true,
            templateUrl: 'BusModal.html',
            controller: 'BusModalController',
            size: 'lg',
            resolve: {
                bus: function () {
                    return bus;
                }
            }
        });

        modalInstance.result.then(function (dataFromModal) {
            $scope.busses.push(dataFromModal); 

        }, function () {
            //$log.info('Modal dismissed at: ' + new Date());
        });

    }
}