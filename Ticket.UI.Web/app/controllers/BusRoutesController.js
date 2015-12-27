angular.module('ticketify')
    .controller('BusRoutesController', BusRoutesController);

BusRoutesController.$inject = ['$scope', 'dataService', 'setupData', 'toasterService'];

function BusRoutesController($scope, dataService, setupData, toaster) {
    var vm = this;
    vm.routes = setupData.routes;
    vm.editRoute = editRoute;
    vm.removeRoute = removeRoute;

    function editRoute(route) {
       // pop up the modal to edit the route
    }

    function removeRoute(route) {
        vm.routes = _.without(vm.routes, route);
        toaster.success('Route removed'); 
        // send deletion request to the server. 
    }
}