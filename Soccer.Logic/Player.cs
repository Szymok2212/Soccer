using System;

namespace Soccer.Logic
{
    public class Player
    {
        public Player(int speed, int accuracy, int strength, int blok, string name)
        {
            Speed = speed;
            Accuracy = accuracy;
            Strength = strength;
            Blok = blok;
            Name = name;
        }

        public int Speed { get; set; }
        public int Accuracy { get; set; }
        public int Strength { get; set; }
        public int Blok { get; set; }


        public string Name { get; set; }

        public int PlayerPerformance
        {
            get
            {
                return Speed + Accuracy + Strength + Blok;
            }
        }




    }
}
