var Department = /** @class */ (function () {
    function Department(empId, empName, empLocation) {
        var _this = this;
        this.Display = function () {
            console.log("Emp_Id:" + _this.id + "," + "Emp_Name:" + _this.name + "," + "Emp_location:" + _this.location);
        };
        this.id = empId;
        this.name = empName;
        this.location = empLocation;
    }
    return Department;
}());
var obj1 = new Department(250, 'Priyanka', "TamilNadu");
obj1.Display();
