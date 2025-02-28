var Employee1 = /** @class */ (function () {
    function Employee1(name, age) {
        this.name = name;
        this.age = age;
    }
    Employee1.prototype.greet = function () {
        console.log("I am ".concat(this.name, " and I am ").concat(this.age, " years old"));
    };
    return Employee1;
}());
var a = new Employee1("Cristiano", 40);
a.greet();
