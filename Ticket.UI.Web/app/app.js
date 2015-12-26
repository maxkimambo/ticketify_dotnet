var ticketify = (function ($, document, window) {
    var standardTimeout = 5000; 

    // public members
    return {
        autoHide: autoHide
    }; 

    // private stuff 

    function autoHide() {
        setTimeout(function () {
            $('.auto-hide').empty();
        }, standardTimeout);
    }

})($, document, window); 