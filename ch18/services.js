angular.module("customServices", [])
    .provider("logService", function() {
        let counter = true;
        let debug = true ;
        return { 
            messageCounterEnabled: function (setting) {
                if (angular.isDefined(setting)) {
                    counter = setting ;
                    return this;
                } else {
                    return counter ;
                }
            },
            debugEnabled: function (setting) {
                if (angular.isDefined(setting)) {
                    debug = setting ;
                    return this;
                } else {
                    return debug ;
                }
            },
            $get: function() {
                return {
                    messageCount: 0,
                    log: function(msg) {
                        if (debug) {
                            console.log("(LOG" 
                                + (counter ? " + " + this.messageCount++ + ") " : ") ")
                                + msg);
                        }
                    }
                };
            }
        };
    });