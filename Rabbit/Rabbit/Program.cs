using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            Rabbit myRabbit = new Rabbit("Rabbit", "Cinnabon", "Blue", "Brown", "Female");
            Console.WriteLine($"The {myRabbit.MammalSpecies} is a mammal!");
            Console.WriteLine($"The gender of the rabbit is {myRabbit.Gender}");
            Console.WriteLine($"The rabbit's name is {myRabbit.Name}");
            Console.WriteLine($"Cinnabon has {myRabbit.Eyes} eyes");
            Console.WriteLine($"Her fur's colour is {myRabbit.Fur}");
          
            myRabbit.Moves();
            myRabbit.Sleeps();
            myRabbit.Eats();
            myRabbit.ActualAge();




        }

    }
}
