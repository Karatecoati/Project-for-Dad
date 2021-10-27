using System;

namespace Project_for_Dad
{
    class Program
    {
        enum skills
        {
            Strength=0,
            Dexterity,
            Sorcery,
            Pyromancy,
            Miracles,
            Challenge,
            Cosplay,
        }

        enum challenges
        {
            Broken_Straight_Sword=0,
            Pryo_Only,
            Sorcery_Only,
            Miracle_Only,
            Soul_Level_One,
        }

        enum cosplays
        {
            Gundyr=0,
            Watcher,
            Dancer,
            Dragonslayer,
            Ornstein,
            Lorian,
            Cinder,
            Nameless,
            Friede,
            Gael,
            Artorias
        }
        static void Main(string[] args)
        {

            var rand = new Random();
            var skill = (skills) rand.Next(Enum.GetNames(typeof(skills)).Length);
            var challenge = (challenges) rand.Next(Enum.GetNames(typeof(challenges)).Length);
            var cosplay = (cosplays) rand.Next(Enum.GetNames(typeof(challenges)).Length);

            switch (skill)
            {
                case skills.Challenge:
                    Console.WriteLine("You are doing a {0} challenge run", challenge);
                    break;
                case skills.Cosplay:
                    Console.WriteLine("You are doing a {0} cosplay run", cosplay);
                    break;
                default: Console.WriteLine("You are doing a standard run using {0} as your primary skill", skill);
                    break;
            }
        }
    }
}