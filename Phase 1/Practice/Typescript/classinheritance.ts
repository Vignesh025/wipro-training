class Person1
{
    name:string;
    age:number;

    constructor(name:string,age:number)
    {
        this.name = name;
        this.age = age;
    }
    greet()
    {
        console.log(`Hello, My name is ${this.name} and I am ${this.age} years old.`);
    }
}
class Employee extends Person1
{
    position:string;

    constructor(name:string,age:number,position:string)
    {
        super(name,age);
        this.position = position;
    }
    work()
    {
        console.log(`${this.name} is working as a ${this.position}`);
    }
}

let employee = new Employee("Cristiano",40,"footballer");
employee.greet();
employee.work();