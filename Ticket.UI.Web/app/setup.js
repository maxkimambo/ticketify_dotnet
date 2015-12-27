var ticketify = (function ($, document, window) {
    var standardTimeout = 5000;
    var routeId;
    var self = this;

    // public members
    return {
        autoHide: autoHide,
        editRoutesModal: editRoutesModal,
        saveRouteData: saveRouteData,
        deleteRoutesModal: deleteRoutesModal,
        deleteRoute: deleteRoute,
        editRoute: editRoute
    }; 

    // private stuff 
    function autoHide() {
        setTimeout(function () {
            $('.auto-hide').empty();
        }, standardTimeout);
    }
    function getBaseUrl() {
        var baseUrl = $("#routes-table").attr('data-base');
        return baseUrl; 
    }

    function editRoutesModal(id) {
        routeId = id; 
        var baseUrl = getBaseUrl();
        
    }

    function saveRouteData() {
        var baseUrl = getBaseUrl();
        var data = "?id="+routeId +"&"+ $("#routesForm").serialize();
        var url = baseUrl + "/company/editRoute/" + routeId;

        $.ajax({
            dataType: "html",
            url: url,
            method: "POST",
            data: data,
            success: processModalData
            }); 

        function processModalData(data) {
            console.log(data); 
        }
    }


    function deleteRoutesModal(id) {

        routeId = id;
        var baseUrl = getBaseUrl();
        $("#deleteRouteModal").modal('toggle'); 

    }

    function deleteRoute() {
       
        console.log(routeId);
        // close the dialog 
        var url = getBaseUrl() + "/company/deleteroute/" + routeId;

        // send the request to delete. 
        $.ajax({
            dataType: "html",
            url: url,
            method: "POST",
            success: refreshRouteTab
        });

       
        $("#deleteRouteModal").modal('toggle');
    }

    function refreshRouteTab(data) {
        $("#routes-table").html(data);

    }

    function editRoute() {
        var url = getBaseUrl() + "/company/editRoute/" + routeId;
        var data = {}; 
        // send the request to delete. 
        $.ajax({
            dataType: "html",
            url: url,
            data: data,
            method: "POST",
            success: self.refreshRouteTab
        });

        $("#routeModal").modal('toggle');


    }


})($, document, window); 