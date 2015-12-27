// get module and attach controller function to it. 
angular.module('ticketify').controller('BussesController', BussesController);

// injection 
BussesController.$inject = ['$scope', 'setupData', 'dataService', 'toasterService']; 

// actual controller 
function BussesController($scope, setupData, data, toast) {

    var vm = this;
    vm.busses = setupData.busses;
    vm.removeBus = removeBus;
    vm.editBus = editBus;

    function removeBus(bus) {

        var indx = vm.busses.indexOf(bus);
        vm.busses.splice(indx, 1);
        toast.success('Bus removed'); 
    };
       

    function editBus(bus) {
        console.log('editing', bus); 
    }



}