using System;

using Animal;
	
public class Dog : Animal
{
	public Dog()
    {
        super(15);
        Console.WriteLine("A dog has been created");
    }

    public void ruff()
    {
        Console.WriteLine("The dog says ruff");
    }

    public void run()
    {
        Console.WriteLine("A dog is running");
    }
}

