angular.module('ticketify')
    .service('toasterService', toasterService);

toasterService.$inject = ['toaster']; 
function toasterService(toaster) {

    var timeout = 5000; 

    var service = {
        success: success,
        error: error,
        warning: warning,
        info : info
    }
    return service;

    // implementation 
    function success(message) {
        
        toaster.pop('success', 'Success', message, timeout, 'trustedHtml'); 
    }

    function error(message) {
        toaster.pop('danger', 'Error', message, timeout, 'trustedHtml'); 
    }

    function warning(message) {
        toaster.pop('warning', 'Warning', message, timeout, 'trustedHtml');
    }

    function info(message) {
        toaster.pop('info', 'Info', message, timeout, 'trustedHtml');
    }
}