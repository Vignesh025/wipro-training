var Person = /** @class */ (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    Person.prototype.greet = function () {
        console.log("Hello, My name is ".concat(this.name, " and I am ").concat(this.age, " years old."));
    };
    return Person;
}());
var x = new Person("Cristiano", 40);
x.greet();
