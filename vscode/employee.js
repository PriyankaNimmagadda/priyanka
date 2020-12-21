var Employee = /** @class */ (function () {
    function Employee(empId, empName, empSalary, empMobileNo) {
        var _this = this;
        this.Display = function () {
            console.log("emp id:" + _this.id + " ", "emp name:" + _this.name + " " + "emp salary:" + _this.salary + " " + "emp mobile no:" + 7801036508);
        };
        this.id = empId;
        this.name = empName;
        this.salary = empSalary;
        this.mobileNo = empMobileNo;
    }
    return Employee;
}());
var obj = new Employee(250, "Priyanka", 23000.50, 7801036508);
obj.Display();
