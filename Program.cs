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
            var skillCount = Enum.GetNames(typeof(skills)).Length;
            var skillInt = rand.Next(skillCount);
            var skillStr = (skills) skillInt;

            var rando = new Random();
            var challengeCount = Enum.GetNames(typeof(challenges)).Length;
            var challengeInt = rando.Next(challengeCount);
            var challengeStr = (challenges) challengeInt;

            var randow = new Random();
            var cosplayCount = Enum.GetNames(typeof(cosplays)).Length;
            var cosplayInt = randow.Next(cosplayCount);
            var cosplayStr = (cosplays) cosplayInt;
            
            if (skillInt == 5)
            {
                Console.WriteLine("You are doing a {0} challenge run", challengeStr);
            }
            else if (skillInt == 6)
            {
                Console.WriteLine("You are doing a {0} cosplay run", cosplayStr);
            }
            else
            {
                Console.WriteLine("You are doing a standard run using {0} as your primary skill", skillStr);
            }
        }
    }
}