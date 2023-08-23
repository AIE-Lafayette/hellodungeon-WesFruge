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
            Console.WriteLine("'Here take one of these you might need them!' - Luci");
            Console.WriteLine("'You can go with one of these three classes only to start. Slash: The medium damaging, high sustaing class. Bludegoning: The low damage, very high health class. And lastly Piercing: The high damage, low health class.' - Luci");

            //Misc important
            bool playerLife = true;
            float playerHealth = 0;
            bool gameOver = playerLife = false;

            //Classes
            string classChoice = Console.ReadLine();
            string Weapon1 = "Slash";
            float weaponUses1 = 5.0f;
            bool weaponSkill1 = true;
            float damage1 = 9.0f;
            float sHealth = 15.0f;
            string heroName1 = "Slai Tu";

            Console.ReadLine();
            string Weapon2 = "Bludgeoning";
            float weaponUses2 = 10.0f;
            bool weaponSkill2 = true;
            float damage2 = 5.0f;
            float bHealth = 25.0f;
            string heroName2 = "Blo Tu";

            Console.ReadLine();
            string Weapon3 = "Piercing";
            float weaponUses3 = 1.0f;
            bool weaponSkill3 = true;
            float damage3 = 13.0f;
            float pHealth = 10.0f;
            string heroName3 = "Pyrc Tu";


            //Enemies stage 1
            string e1 = "Goblin";

            string e2 = "Slime";

            string e3 = "Fey";



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

            string Weapon11 = "Archer";

            string Weapon12 = "Beast Tamer";
            


            //BBEG
            string Weapon666 = ""
            

        }
    }
}
