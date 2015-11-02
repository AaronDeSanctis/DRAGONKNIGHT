using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fightBool = true;
            RPG_Player player = new RPG_Player();
            Weapon blade = new Weapon();
            Story story = new Story();
            Battle randomBattle = new Battle(player);
            story.Intro();
            Console.ReadLine();
            story.BeginGame();
            Console.ReadLine();
            story.FirstEnemy(randomBattle);
            Console.ReadLine();
            story.Chapter1Part1();
            Console.ReadLine();
            story.FirstEnemy(randomBattle);
            Console.ReadLine();
            story.FirstEnemy(randomBattle);
            Console.ReadLine();
            story.Chapter1Part2();
            Console.ReadLine();
            while (fightBool == true)
            {
                story.FirstEnemy(randomBattle);
                if (randomBattle.playeralive == false)
                {
                    fightBool = false;
                }
                else fightBool = true;
            }
            Console.ReadLine();
            story.Chapter1Part3();
            while (fightBool == true)
            {
                story.FirstEnemy(randomBattle);
            }
                
            

           
        }
    }
}
