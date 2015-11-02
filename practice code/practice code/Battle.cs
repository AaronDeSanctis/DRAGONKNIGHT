using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    public class Battle
    {
        Monster currentMonster;
        RPG_Player player;
        Random random;
        public bool monsteralive;
        public bool playeralive;
        public Battle(RPG_Player user)
        {
            monsteralive = true;
            playeralive = true;
            currentMonster = new Monster();
            player = user;
            random = new Random();
        }

        public void Fight()
        {
            monsteralive = true;
            Console.WriteLine("If want to fight this monster press 1");
            Console.WriteLine("If you want to heal and run away press 2");
        if (Console.ReadLine() == "1")
        {
                
            while (monsteralive && playeralive)
            {
                    Console.WriteLine("You Attacked for " + ("" + currentMonster.TakeDamage(player.Attack())) + " damage");
                    Console.WriteLine("Monster has " + currentMonster.CurrentHP.ToString() + " HP remaining.");
                    Console.ReadLine();
                    if (currentMonster.CurrentHP > 0)
                    {
                        Console.WriteLine("Monster Attacked for " + ("" + player.TakeDamage(currentMonster.Attack())) + " damage");
                        Console.WriteLine("You have " + player.CurrentHP.ToString() + " HP remaining.");
                        Console.ReadLine();
                    }
                    if (currentMonster.CurrentHP <= 0)
                    {
                        Console.WriteLine("You defeated the monster!");
                        Console.WriteLine();
                        currentMonster.CurrentHP = currentMonster.MaxHP;
                        player.EXP += currentMonster.EXPDropped;
                        int chance = random.Next(1, 10);
                        if (chance <= 3)
                        {
                            currentMonster.DropLootSword();
                        }
                        if (chance == 4)
                        {
                            currentMonster.DropLootIceSword();
                        }
                        
                        else if (player.MaxEXPNeeded <= player.EXP)
                        {
                            player.LevelUp();
    
                        }
                        monsteralive = false;
                        return;
                    }
                    else if (player.CurrentHP <= 0)
                    {
                        Console.WriteLine("You were killed by the monster!");
                        player.CurrentHP = player.MaxHP;
                        Console.WriteLine("Your HP = " + player.CurrentHP.ToString());
                        playeralive = false;
                        return;
                    }
                }
        }
        if (Console.ReadLine() == "2")
        {
            player.Heal();
            Console.WriteLine("You have Healed " + player.MagDMG.ToString());
            return;
        }
        else
            {
            
            }
        }
    }
}
