angular.module("customServices", [])
    .factory("logService", function($log) {
        return {
            messageCount: 0,
            log: function (msg) {
                if (debug) {
                    $log.log("(LOG" 
                        + (counter ? " + " + this.messageCount++ + ") " : ") ")
                        + msg);
                }
            }
        }
    });