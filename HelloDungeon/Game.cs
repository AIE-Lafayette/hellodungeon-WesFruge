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
            Console.ReadKey(true);
            Console.WriteLine("'Hiya broski'- Strange voice");
            Console.WriteLine("'My name is Luci!' - Luci");
            Console.WriteLine("'This world is evil. I shal prepare you!' - Luci");
            Console.ReadKey(true);
            Console.WriteLine("'Here take one of these you might need them!' - Luci");
            

            //Base Status
            float playerHealth = 0;
            float playerDamage = 0.0f;
            string playerName = "";
            float enemyHealth = 0;
            float enemyDamage = 0.0f;

            //Initalize Class Stats
            string classChoice;
        

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

            bool classSelected = false;
            while (classSelected == false)
            {
                Console.WriteLine("'You can go with one of these three classes only to start.'");
                Console.WriteLine("'Slash: The medium damaging, high sustaing class.'");
                Console.WriteLine("'Bludegoning: The low damage, very high health class.'");
                Console.WriteLine("'And lastly Piercing: The high damage, low health class.' - Luci'");
                Console.Write(">");
                classChoice = Console.ReadLine();




                if (classChoice.ToLower() == "slash")
                {
                    classSelected = true;
                    playerDamage = sDamage;
                    playerHealth = sHealth;
                    playerName = heroName1;
                    Console.WriteLine("'You have chosen the Slash class. This class weilds weapons known for their slicing and dicing power. You shal start with a sword!'");
                }
                else if (classChoice.ToLower() == "bludegoning")
                {
                    classSelected = true;
                    playerDamage = bDamage;
                    playerHealth = bHealth;
                    playerName = heroName2;
                    Console.WriteLine("You have chosen the Bludegoning class. This class weilds weapons known for raw damage output. You shal start with a Club!'");
                }
                else if (classChoice.ToLower() == "piercing")
                {
                    classSelected = true;
                    playerDamage = pDamage;
                    playerHealth = pHealth;
                    playerName = heroName3;
                    Console.WriteLine("You have chosen the Piercing class. This class weilds weapons known for thir penatrative power. You shal start with a bow!");
                }
            }
            //Entering the world
            Console.WriteLine("*You open your eyes and see the light*");
            Console.ReadKey(true);
            Console.WriteLine("*You walk towards it*");
            Console.ReadKey(true);
            Console.WriteLine("*As your eyes adjust you realize you have entered into a massive gladatorial stadium*");
            Console.ReadKey(true);
            Console.WriteLine("'DEMONS AND ANGLES WELCOME TO PURGATORY!'-Luci");
            Console.WriteLine("'On this beautiful day this human shal fight for the fate of humanity!'-Luci");
            Console.WriteLine("'Shal they win, humanity will live on our earth another 1,000 years. But if they fall in combat... Well lets just say the 4 horsemen and us shal have some fun!'-Luci");
            Console.WriteLine("'LET GLORIOUS COMBAT... COMINSE!'-Luci");
            Console.ReadKey(true);
            Console.WriteLine("*You see three enemies magically spawn infront of you*");
            Console.WriteLine("*A Goblin*");
            Console.WriteLine("*A Slime*");
            Console.WriteLine("*A Fey*");
            Console.ReadKey(true);
            Console.WriteLine("*You must choose one to fight, the other two will eliminate eachother*");
            Console.Write(">");



            //Enemies stage 1
            string enemyChoice;
            enemyChoice = Console.ReadLine();

            string e1 = "Goblin";
            float e1Damage = 5.0f;
            float e1Health = 10f;

            string e2 = "Slime";
            float e2Damage = 2.0f;
            float e2Health = 20f;

            string e3 = "Fey";
            float e3Damage = 6.0f;
            float e3Health = 4.0f;

            if (enemyChoice == "Goblin")
            {
                enemyDamage = e1Damage;
                enemyHealth = e1Health;
            }
            else if (enemyChoice == "Slime")
            {
                enemyDamage = e2Damage;
                enemyHealth = e2Health;
            }
            else if (enemyChoice == "Fey")
            {
                enemyDamage = e3Damage;
                enemyHealth = e3Health;
            }

            //Battle code
            bool playerAlive = true;
            bool enemyAlive = true;


            while (playerAlive == true && enemyAlive == true)
            {
                if (enemyHealth <= 0)
                {
                    enemyAlive = false;
                }
                if (playerHealth <= 0)
                {
                    playerAlive = false;
                }
                Console.WriteLine("'Player Stats'");
                Console.WriteLine(playerHealth);
                Console.WriteLine(playerDamage);
                Console.WriteLine("'Enemy Status'");
                Console.WriteLine(enemyHealth);
                Console.WriteLine(enemyDamage);
                Console.ReadKey(true);
                enemyHealth -= playerDamage;
                playerHealth -= enemyDamage;
             
            }
            //Dialogue
            Console.WriteLine("'HA YOUVE PASSED THE SIMPLE BATTLE!- Luci");
            Console.ReadKey(true);
            Console.WriteLine("'Round two! Begin.- Luci *he claps twice*");
            Console.WriteLine("*Three more enemies spawn around you. Same rules as last time*");
            Console.ReadKey(true);
            Console.WriteLine("*First theres an Orc*");
            Console.WriteLine("*Second theres an Imp*");
            Console.WriteLine("*Lastly theres a Plague Doctor. Nows hes special! He deals increased dmg over turns*");
            Console.Write(">");


            //Enemies stage 2
            string enemyChoice2;
            enemyChoice2 = Console.ReadLine();

            string e4 = "Orc";
            float e4Damage = 7.0f;
            float e4Health = 12.0f;


            string e5 = "Imp";
            float e5Damage = 12.0f;
            float e5Health = 7.0f;

            string e6 = "Plague Doctor";
            float e6Damage = 6.0f;
            float e6Health = 10.0f;

            if (enemyChoice2 == "Orc")
            {
                enemyDamage = e4Damage;
                enemyHealth = e4Health;
            }
            else if (enemyChoice2 == "Imp")
            {
                enemyDamage = e5Damage;
                enemyHealth = e5Health;
            }
            else if (enemyChoice2 == "Plague Doctor")
            {
                enemyDamage = e6Damage;
                enemyHealth = e6Health;
            }
           
            
            while (playerAlive == true && enemyAlive == true)
            {
                if (enemyHealth <= 0)
                {
                    enemyAlive = false;
                }
                if (playerHealth <= 0)
                {
                    playerAlive = false;
                }
                Console.WriteLine("'Player Stats'");
                Console.WriteLine(playerHealth);
                Console.WriteLine(playerDamage);
                Console.WriteLine("'Enemy Status'");
                Console.WriteLine(enemyHealth);
                Console.WriteLine(enemyDamage);
                Console.ReadKey(true);
                enemyHealth -= playerDamage;
                playerHealth -= enemyDamage;

            }

            //enemies stage 3
            string e7 = "Ice Drake";
            float e7Damage = 5.0f;
            float e7Health = 20.0f;

            string e8 = "Wind Drake";
            float e8Damage = 6.0f;
            float e8Health = 18.0f;

            string e9 = "Rock Drake";
            float e9Damage = 5.5f;
            float e9Health = 30.0f;




            //Subclasses for slash
            string Weapon4 = "Guts and Gore";
            float w4Damage = 15.0f;
            float w4Health = 20.0f;

            string Weapon5 = "Beauty In The Bleeding";
            float w5Damage = 9.0f;
            float w5Health = 18.0f;

            string Weapon6 = "Executioner";
            float w6Damage = 13.0f;
            float w6Health = 10.0f;
            float exePoint = 12.0f;


            //Subclasses for bludgeoning
            string Weapon7 = "Sir Morningstar";
            float w7Damage = 11.0f;
            float w7Health = 23.0f;

            string Weapon8 = "Sir Warhammer";
            float w8Damage = 14.0f;
            float w8Health = 30.0f;

            string Weapon9 = "Sir Monk";
            float w9Damage = 17.0f;
            float w9Health = 20.0f;



            //Subclass for piercing
            string Weapon10 = "Eternal Swarm";
            float w10Damage = 10.0f;
            float w10Health = 12.0f;

            string Weapon11 = "Gun blade";
            float w11Damage = 15.0f;
            float w11Health = 15.0f;

            string Weapon12 = "Beast Tamer";
            float w12Damage = 13.0f;
            float w12Health = 18.0f;



            //BBEG
            string Weapon666 = "Lucifer";
            float w666Damage = 20.0f;
            float w666Health = 66.0f;

            string Weapon000 = "Azeral";
            float w000Damage = 10.0f;
            float w000Health = 120.0f;

            string Weapon999 = "Micheal";
            float w999Damage = 50.0f;
            float w999Health = 33.0f;

        }
    }
}
