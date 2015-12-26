var ticketify = (function ($, document, window) {
    var standardTimeout = 5000;
    var routeId; 

    // public members
    return {
        autoHide: autoHide,
        showModal: showRoutesModal,
        deleteRoutesModal: deleteRoutesModal,
        deleteRoute: deleteRoute
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
    function showRoutesModal(id) {
        var baseUrl = getBaseUrl(); 

        var url = baseUrl + "/company/routes/" + id; 
        $.ajax({
            dataType: "json",
            url: url,
            method: "GET",
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

        function refreshRouteTab(data) {
            $("#routes-table").html(data);
            $("#deleteRouteModal").modal('toggle');
        }
    }


})($, document, window); 