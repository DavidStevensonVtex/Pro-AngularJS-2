angular.module("exampleApp")
    .filter("labelCase", function() {
        return function ( value, reverse ) {
            if ( angular.isString(value) ) {
                let intermediate = reverse ? value.toUpperCase() : value.toLowerCase() ;
                return ( reverse ? intermediate[0].toLowerCase() : 
                    intermediate[0].toUpperCase()) + intermediate.substr(1);
            } else {
                return value;
            }
        }
    });