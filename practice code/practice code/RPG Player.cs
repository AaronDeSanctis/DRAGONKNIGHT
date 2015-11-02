using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    public class RPG_Player
    {
        public int MaxHP;
        public int DMG;
        public int MoveSpeed;
        public int Level;
        public int MagDMG;
        public int AtkSpd;
        public int CurrentHP;
        public int MaxMana;
        public int CurrentMana;
        public int EXP;
        public int MaxEXPNeeded;
        Weapon playerWeapon;
        Monster enemy;
        public RPG_Player()
        {
                MaxHP = 100;
                DMG = 5;
                MoveSpeed = 25;
                AtkSpd = 10;
                Level = 1;
                MagDMG = 5;
                CurrentHP = 100;
                MaxMana = 10;
                MaxEXPNeeded = 5;
                playerWeapon = new Weapon();
                enemy = new Monster();
 
                EXP = 0;
        }
        public void LevelUp()
        {
            Level =Level + 1;
            DMG = DMG + 2; 
            MaxHP = MaxHP + 5;
            AtkSpd = AtkSpd + 1; 
            MoveSpeed = MoveSpeed + 1;
            MagDMG = MagDMG + 2;
            MaxMana = MaxMana + 2;
            EXP = 0;
            MaxEXPNeeded = MaxEXPNeeded + 20;
            enemy.LevelUp();
            Console.WriteLine("You have leveled up to {0}", Level);
            Console.WriteLine("Max HP = " + MaxHP.ToString());
            Console.WriteLine("Max Mana = " + MaxMana.ToString());
            Console.WriteLine("Damage = " + DMG.ToString());
            Console.WriteLine("Magic Damage = " + MagDMG.ToString());
            Console.WriteLine("Attack Speed = " + AtkSpd.ToString());
            Console.WriteLine("Move Speed = " + MoveSpeed.ToString());
            CurrentHP = MaxHP;
            Console.ReadLine();
         }
        public int Attack()
        {
            //CurrentMonsterHP = CurrentMonsterHP - DMG;
            return DMG;
           
        }
        public void SoulSteal()
        {
            enemy.CurrentHP = enemy.CurrentHP - MagDMG;
            CurrentHP = CurrentHP + MagDMG;
        }
        public void LightningBolt()
        {
            enemy.CurrentHP = enemy.CurrentHP - (MagDMG * 2);
           
        }
        public void Heal()
        {
            CurrentHP = CurrentHP + MagDMG;
           
        }
        public void DoubleStrike()
        {
            enemy.CurrentHP = enemy.CurrentHP - (DMG * 2);
            CurrentHP = CurrentHP - 20;
            
        }

        public int TakeDamage(int damage)
        {
            CurrentHP -= damage;
            return damage;
        }
        public void EquipWeapon(string weaponName)
        {
            DMG -= playerWeapon.DMG;
            playerWeapon.WeaponSelect(weaponName);
            DMG += playerWeapon.DMG;
        }
        
        
    }
}
