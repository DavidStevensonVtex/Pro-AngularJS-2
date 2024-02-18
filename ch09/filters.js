angular.module("exampleApp.Filters", []).filter("dayName", function() {
    let dayNames = [ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ];
    return function(input) {
        return angular.isNumber(input) ? dayNames[input] : input ;
    }
});