using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    public enum Eyes
    {
        Blue,
        Red,
        Black
    }
    public enum Fur
    {
        White,
        Brown,
        Black,
        Grey,
    }
    public enum Gender
    {
        Female,
        Male
    }
    class Rabbit
    {
        public string MammalSpecies { get; }
        public string Name { get; }
        public string Eyes { get; }
        public string Fur { get; }
        public string Gender { get; }

        public Rabbit(string mammalspecies, string name, string eyes, string fur, string gender)
        {
            MammalSpecies = mammalspecies;
            Name = name;
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
        }
    }
}
