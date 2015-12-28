'use strict';

angular.module('ticketify').controller("CompanyController", CompanyController);
CompanyController.$inject = ['$scope', 'setupData', 'toasterService'];

function CompanyController($scope, setupData, toast) {
    var vm = this;
    vm.company = setupData.company;
    vm.notifySuccess = notifySuccess;
    vm.notifyError = notifyError;

    function notifySuccess(message) {
        toast.success(message); 
    }

    function notifyError(message) {
        toast.error(message);
    }
   
}