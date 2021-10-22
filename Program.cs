using System;

namespace Project_for_Dad
{
    class Program
    {
        static void Main(string[] args)
        {
            string skillsanswer;
            string challengesanswer;
            string cosplaysanswer;
            string[] skills = {"Strength", "Dexterity", "Sorcery", "Pyromancy", "Miracles", "Challenge Run", "Cosplay Run"};
            string[] challenges =
                {"Broken Straight Sword", "Pyro Only", "Sorcery Only", "Miracles Only", "Soul Level 1"};
            string[] cosplays =
            {
                "Iudex Gundyr", "Abyss Watcher", "Dancer", "Dragonslayer Armour/Ornstein", "Lorian", "Soul of Cinder",
                "Nameless King", "Sister Friede", "Slave Knight Gael", "Artorias", "Smough"
            };

            Random rand = new Random();
            int index = rand.Next(skills.Length);
            skillsanswer = Convert.ToString(skills[index]);
            Random rando = new Random();
            int indextwo = rando.Next(challenges.Length);
            challengesanswer = Convert.ToString(challenges[indextwo]);
            Random randow = new Random();
            int indexthree = randow.Next(challenges.Length);
            cosplaysanswer = Convert.ToString(cosplays[indexthree]);

            if (skillsanswer == "Challenge Run")
            {
                Console.WriteLine("You are doing a {0} challenge run", challengesanswer);
            }
            else if (skillsanswer == "Cosplay Run")
            {
                Console.WriteLine("You are doing a {0} cosplay run", cosplaysanswer);
            }
            else
            {
                Console.WriteLine("You are doing a standard run using {0} as your primary skill", skillsanswer);
            }
        }
    }
}