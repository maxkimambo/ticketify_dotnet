// get module and attach controller function to it. 
angular.module('ticketify').controller('BussesController', BussesController);

// injection 
BussesController.$inject = ['$scope', 'setupData', 'dataService']; 

// actual controller 
function BussesController($scope, setupData, data) {

    var vm = this;
    vm.busses = setupData.busses;
    vm.removeBus = removeBus;
    vm.editBus = editBus;

    function removeBus(bus) {

        var indx = vm.busses.indexOf(bus);
        vm.busses.splice(indx, 1); 

    };
       

    function editBus(bus) {
        console.log('editing', bus); 
    }



}