angular.module("customServices", [])
    .factory("logService", function() {
        var messageCount = 0 ;
        return { 
            log: function(msg) {
                ("(LOG + " + messageCount++ + ") " + msg);
            }
        };
    });