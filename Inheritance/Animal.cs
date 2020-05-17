using System;
using System.Linq.Expressions;

namespace Animal
{
    public class Animal
    {
        public int age;

        public Animal(int age)
        {
            this.age = age;
            Console.WriteLine("An animal has been created");
        }
        public void eat()
        {
            Console.WriteLine("An animal is eating");
        }
        public static void Main(String[] args)
        {
            Animal a = new Animal(5);
            Dog d = new Dog();
            Cat c = new Cat();
            d.ruff();
            Console.WriteLine(d.age());
            c.meow();
            Console.WriteLine(c.age());
            a.eat();
            d.eat();
            c.eat();
            d.run();
            c.prance();
        }
    }
}
