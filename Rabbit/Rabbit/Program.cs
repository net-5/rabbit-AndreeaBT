using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            MammalRabbit myRabbit = new MammalRabbit(MammalType.Rabbit,"Cinnabon", "Blue", "Brown", "Female",  new DateTime(2016,03,24),"Jumps", "With one eye open", "Carrots");
            Console.WriteLine($"The {MammalType.Rabbit} is a mammal!");
            Console.WriteLine($"The gender of the rabbit is {myRabbit.Gender}");
            Console.WriteLine($"The rabbit's name is {myRabbit.Name}");
            Console.WriteLine($"Cinnabon has {myRabbit.Eyes} eyes");
            Console.WriteLine($"Her fur's colour is {myRabbit.Fur}");
            Console.WriteLine($"She {myRabbit.Moves} all over the place");
            Console.WriteLine($"She sleeps {myRabbit.Sleeps}");
            Console.WriteLine($"Cinnabon eats a lot of {myRabbit.Eats}");
            Console.WriteLine($"She was born on {myRabbit.BirthDate}");



            DateTime today = DateTime.Now;
            TimeSpan span = today - new DateTime(2016,03,24);
            DateTime age = DateTime.MinValue + span;
            int years = age.Year - 1;
            int months = age.Month - 1;
            Console.Write($"And now her age is :{years} years and {months} months", years, months);

        }

    }
}
