﻿Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName); 

Dog neighbourDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighbourDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();
class Dog
{
    private string _name; //field
    private int _levelOfHappiness;

    //constructor
    public Dog(string name)//name - Lets user pick the name
    {
        _name= name;
        _levelOfHappiness = 0;
    } 
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}.");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle!");
    }
}
