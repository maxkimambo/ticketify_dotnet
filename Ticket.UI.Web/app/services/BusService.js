'use strict';

angular.module('ticketify')
    .factory('BusService', BusService);

BusService.$inject = ['dataService', 'urlBase'];

function BusService(dataService, urlBase) {

    var url = urlBase + "Company/";

    var factory = {
        addBus: addBus,
        editBus: editBus,
        removeBus: removeBus
    };

    return factory;

    // implementation. 
    // Adds a bus 
    // id = company Id
    // bus is the bus to add 
    function addBus(id, bus) {
        return dataService.post(url + "AddBus/" + id, bus); 
    }

    function editBus(id, bus) {
        return dataService.put(url  + id, bus); 
    }
    // removes the bus
    // id of the bus to remove
    function removeBus(id) {
        return dataService.del(url + id); 
    }


}