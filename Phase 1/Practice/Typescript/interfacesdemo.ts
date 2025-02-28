interface Person
{
    name:string;
    age:number;
    greet :() => void;
}

class Employee1 implements Person
{
    name:string;
    age:number;

    constructor(name:string, age:number)
    {
        this.name =name;
        this.age = age;
    }
    greet()
    {
        console.log(`I am ${this.name} and I am ${this.age} years old`);
    }
}

let a= new Employee1("Cristiano",40);
a.greet();

