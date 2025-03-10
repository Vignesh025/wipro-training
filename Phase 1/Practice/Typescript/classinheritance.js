var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Person1 = /** @class */ (function () {
    function Person1(name, age) {
        this.name = name;
        this.age = age;
    }
    Person1.prototype.greet = function () {
        console.log("Hello, My name is ".concat(this.name, " and I am ").concat(this.age, " years old."));
    };
    return Person1;
}());
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(name, age, position) {
        var _this = _super.call(this, name, age) || this;
        _this.position = position;
        return _this;
    }
    Employee.prototype.work = function () {
        console.log("".concat(this.name, " is working as a ").concat(this.position));
    };
    return Employee;
}(Person1));
var employee = new Employee("Cristiano", 40, "footballer");
employee.greet();
employee.work();
