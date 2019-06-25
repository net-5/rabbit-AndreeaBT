using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    public enum MammalType
    {
        Rabbit,
        Moves,
        Sleeps,
        Eats,
    }

    class Rabbit
    {
        public string Name { get; }
        public string Eyes { get; }
        public string Fur { get; }
        public string Gender { get; }

        public Rabbit(MammalType type, string name, string eyes, string fur, string gender)
        {
            Name = name;
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
        }
        public void Moves()
        {
            Console.WriteLine("I jump all over the place.");
            
        }

        public void Sleeps()
        {
            Console.WriteLine("Cinnabon sleeps with one eye open.");
        }

        public void Eats()
        {
            Console.WriteLine("She eats a lot of carrots!");
        }
        public void ActualAge()
        {
            DateTime today = DateTime.Now;
            TimeSpan span = today - new DateTime(2016, 03, 24);
            DateTime age = DateTime.MinValue + span;
            int years = age.Year - 1;
            int months = age.Month - 1;
            Console.Write($"And now her age is :{years} years and {months} months", years, months);
        }
    }   





}
    

