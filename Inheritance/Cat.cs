using System;

using Animal;

public class Cat : Animal
{
	public Cat()
    {
        super(7);
        Console.WriteLine("A cat has been cerated");
    }

    public void meow()
    {
        Console.WriteLine("A Cat has been meow");
    }

    public void prance()
    {
        Console.WriteLine("A cat is prancing");
    }
}
