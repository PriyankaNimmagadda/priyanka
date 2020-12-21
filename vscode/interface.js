var person = /** @class */ (function () {
    function person() {
    }
    person.prototype.GetFullName = function () {
        console.log(this.firstName + " " + this.lastName);
    };
    return person;
}());
var objP = new person();
objP.firstName = "priyanka";
objP.lastName = "Nimmagadda";
objP.GetFullName();
