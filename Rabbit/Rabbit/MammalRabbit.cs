using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    public enum MammalType
    {
        Rabbit,
        Name,
        BirthDay,
        Moves,
        Sleeps,
        Eats,
    }

    class MammalRabbit
    {
        public string Moves { get; set; }
        public string Sleeps { get; set; }
        public string Eats { get; set; }
        public DateTime BirthDate { get; }
        
        
        public string Name { get; }
        public string Eyes { get; }
        public string Fur { get; }
        public string Gender { get; }



        public MammalRabbit( MammalType type, string name, string eyes, string fur, string gender,  DateTime birthdate,  string moves, string sleeps, string eats)
        {
            
            Name = name;
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
            BirthDate = birthdate;
            
            Moves = moves;
            Sleeps = sleeps;
            Eats = eats;
        }
       


    }




}
    

