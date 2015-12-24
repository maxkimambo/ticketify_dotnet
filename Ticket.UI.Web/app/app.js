var ticketify = (function ($, document, window) {
    // public members
    return {
        processCompany: processCompany
    }; 

    // private stuff 

    function processCompany() {
        setTimeout(function () {
            console.log('processed company'); 
            $('#request-result').empty();
        }, 3000);
    }

})($, document, window); 