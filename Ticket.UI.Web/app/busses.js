


var ticketify = (function ($, document, window) {
    var busId;
    var self = this;
    $("#bustable > tbody > tr > td > a").on('click', openBusDialog);

    return {
        saveBusData: saveBusData,
        openBusDialog: openBusDialog
    }

    function openBusDialog(e) {
        console.log(e);

        var id = e.currentTarget.getAttribute('data-id'); 
        console.log(id); 
    }

    function saveBusData() {
        
    }

})($, document, window)