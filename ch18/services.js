angular.module("customServices", [])
    .service("logService", function() {
        return { 
            messageCount: 0,
            log: function(msg) {
                console.log("(LOG + " + (this.messageCount++) + ") " + msg);
            }
        };
    });