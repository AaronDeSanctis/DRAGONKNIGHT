using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    class Story
    { 
        public Story()
        {

        }
        public void Intro()
        {
            Console.WriteLine("*************");
            Console.WriteLine("DRAGON KNIGHT");
            Console.WriteLine("*************");
            Console.WriteLine("Made by Knee-skez and Aaron");
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to start");
        }
        public void BeginGame()
        {
            Console.WriteLine("");
            Console.WriteLine("........You walk up to a foreign ancient castle slowly.");
            Console.WriteLine("Your side is bleeding and your armor is bent and broken.");
            Console.WriteLine("You don't see anyone, but you know in your gut you're not alone.");
            Console.WriteLine("");
        }
        public void FirstEnemy(Battle REB)
        {
            Console.WriteLine("");
            Console.WriteLine("You spotted a Wraith!!");
            Console.WriteLine("");
            REB.Fight();
        }
        public void Chapter1Part1()
        {
            Console.WriteLine("");
            Console.WriteLine("Killing the ghost-like entity makes you feel rejuvinated.");
            Console.WriteLine("Your wounds look healed and your armor less beat up. But Why??!!");
            Console.WriteLine("You don't have time to sit and think about why because here comes 2 more ");
            Console.WriteLine("");
           
        }
        public void Chapter1Part2()
        {
            Console.WriteLine("");
            Console.WriteLine("You strike down both foes with ease, and prepare yourself for more.");
            Console.WriteLine("As you raise your weapon, flocks of Wraiths start coming through the castle");
            Console.WriteLine("walls. Your heart starts racing. You grip your sword tight.");
            Console.WriteLine("Mentally preparing for what you presume is the end of your adventure.");
            Console.WriteLine("");
        }
        public void Chapter1Part3()
        {
            Console.WriteLine("You see a large flash of light and everything fades to darkness...");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("...");
            Console.ReadLine();
            Console.WriteLine("......'arise'...");
            Console.ReadLine();
            Console.WriteLine("....'arise from your slumber Dragon Knight. You are not dead.'");
            Console.WriteLine("'well you are, but I'll explain that later.'");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("You open your eyes to see a gorgeous woman with large wings and beautiful blonde hair.");
            Console.ReadLine();
            Console.WriteLine("You wonder if you are dreaming but you don't care. Being alone with");
            Console.WriteLine("a woman like this and a campfire by your side is better than dying from");
            Console.WriteLine("ghosts from a haunted castle??!!");
            Console.ReadLine();
            Console.WriteLine("'What the hell is going on?' You ask.");
            Console.ReadLine();
            Console.WriteLine("'Who the hell are you??!!'"); 
            Console.ReadLine();
            Console.WriteLine("The woman doesn't seem to be concerned with you frivolous questions");
            Console.WriteLine("and continues to stare in arbitrary direction.");
            Console.ReadLine();
        }

        
    }
}
