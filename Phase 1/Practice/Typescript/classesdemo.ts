class Person
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

let x= new Person("Cristiano",40);
x.greet();