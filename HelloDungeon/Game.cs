using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Introduction
            Console.WriteLine("'Hiya broski'- Strange voice");
            Console.WriteLine("'My name is Luci!' - Luci");
            Console.WriteLine("'This world is evil. I shal prepare you!' - Luci");
            Console.WriteLine("'Here take one of these you might need them!' - Luci");
            Console.WriteLine("'You can go with one of these three classes only to start.'");
            Console.WriteLine("'Slash: The medium damaging, high sustaing class.'");
            Console.WriteLine("'Bludegoning: The low damage, very high health class.'");
            Console.WriteLine("'And lastly Piercing: The high damage, low health class.' - Luci'");

            //Base Status
            float playerHealth = 0;
            float playerDamage = 0.0f;
            string playerName = "";

            //Initalize Class Stats
            string classChoice;
            classChoice = Console.ReadLine();
          

            string Weapon1 = "Slash";
            float sDamage = 9.0f;
            float sHealth = 15.0f;
            string heroName1 = "Slai Tu";

            
            string Weapon2 = "Bludgeoning";
            float bDamage = 5.0f;
            float bHealth = 25.0f;
            string heroName2 = "Blo Tu";


            string Weapon3 = "Piercing";
            float pDamage = 13.0f;
            float pHealth = 10.0f;
            string heroName3 = "Pyrc Tu";

            if (classChoice == "Slash")
            {
                playerDamage = sDamage;
                playerHealth = sHealth;
                playerName = heroName1;
                Console.WriteLine("'You have chosen the Slash class. This class weilds weapons known for their slicing and dicing power. You shal start with a sword!'");
            }
            else if (classChoice == "Bludegoning")
            {
                playerDamage = bDamage;
                playerHealth = bHealth;
                playerName = heroName2;
                Console.WriteLine("You have chosen the Bludegoning class. This class weilds weapons known for raw damage output. You shal start with a Club!'");
            }
            else if (classChoice == "Piercing")
            {
                playerDamage = pDamage;
                playerHealth = pHealth;
                playerName = heroName3;
                Console.WriteLine("You have chosen the Piercing class. This class weilds weapons known for thir penatrative power. You shal start with a bow!");
            }
            //Entering the world
            Console.WriteLine("*You open your eyes and see the light*");
            Console.WriteLine("*You walk towards it*");
            Console.WriteLine("*As your eyes adjust you realize you have entered into a massive gladatorial stadium*");
            Console.WriteLine("'DEMONS AND ANGLES WELCOME TO PURGATORY!'-Luci");
            Console.WriteLine("'On this beautiful day this human shal fight for the fate of humanity!'-Luci");
            Console.WriteLine("'Shal they win, humanity will live on our earth another 1,000 years. But if they fall in combat... Well lets just say the 4 horsemen shal and us shal have some fun!'-Luci");
            Console.WriteLine("'LET GLORIOUS COMBAT... COMINSE!'-Luci");
            Console.WriteLine("*You see three enemies magically spawn infront of you*");
            Console.WriteLine("*You must choose one to fight, the other two will eliminate eachother*");


            //Enemies stage 1
            string e1 = "Goblin";

            string e2 = "Slime";

            string e3 = "Fey";


            //Enemies stage 2
            string e4 = "Orc";


            string e5 = "Imp";

            string e6 = "Plague Doctor";


            //enemies stage 3
            string e7 = "Ice Drake";

            string e8 = "Wind Drake";

            string e9 = "Rock Drake";
                



            //Subclasses for slash
            string Weapon4 = "Guts and Gore";

            string Weapon5 = "Beauty In The Bleeding";

            string Weapon6 = "Executioner";



            //Subclasses for bludgeoning
            string Weapon7 = "Sir Morningstar";

            string Weapon8 = "Sir Warhammer";

            string Weapon9 = "Sir Monk";



            //Subclass for piercing
            string Weapon10 = "Eternal Swarm";

            string Weapon11 = "Gun blade";

            string Weapon12 = "Beast Tamer";



            //BBEG
            string Weapon666 = "Lucifer";

            string Weapon000 = "Azeral";

            string Weapon999 = "Micheal";

        }
    }
}
