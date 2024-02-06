using System;

public class Car
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }

    public Car(string model, string manufacturer)
    {
        Model = model;
        Manufacturer = manufacturer;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details: {Manufacturer} {Model}");
    }
}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    private Car car; 

    public Person(string name, int age, Car car)
    {
        Name = name;
        Age = age;
        this.car = car;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        car.DisplayDetails(); 
    }
}


class Program
{
    static void Main(string[] args)
    {
        
        Car myCar = new Car("Civic", "Honda");

        
        Person person1 = new Person("John", 30, myCar);

        
        Console.WriteLine("Person Information:");
        person1.DisplayInfo();
    }
}
