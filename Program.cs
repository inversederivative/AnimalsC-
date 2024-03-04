namespace Animals
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }

    class Horse : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Neihhh!");
        }
    }


    class Program
    {
        public static int Main(string[] args)
        {
            Animal animal = new Dog();
            animal.MakeSound();

            animal = new Cat();
            animal.MakeSound();

            animal = new Horse();
            animal.MakeSound(); 

            return 0;
        }
    }
}