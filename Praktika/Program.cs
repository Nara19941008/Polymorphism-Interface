using System;

namespace Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

            
            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();



            Test test = new Test();
            test.Id = 6;



        }
    }
}
