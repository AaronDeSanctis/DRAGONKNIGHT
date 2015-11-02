using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    public class Monster
    {
        public Weapon Sword;
        public int MaxHP;
        public int DMG;
        public int CurrentHP;
        public bool ItemDrop;
        public int EXPDropped;
        public Monster()
        {
            Sword = new Weapon();
            MaxHP = 30;
            DMG = 5;
            EXPDropped = 5;
            CurrentHP = MaxHP;
            ItemDrop = false;
        }

        public int Attack()
        {
            return DMG;
        }

        public int TakeDamage(int damage)
        {
            CurrentHP -= damage;
            return damage;
        }
        public void DropLootSword()
        {
            Sword.WeaponSelect("Sword");
        }
        public void DropLootIceSword()
        {
            Sword.WeaponSelect("Ice Blade");
        }
        public void LevelUp()
        {
            MaxHP = MaxHP += 5;
            DMG = DMG += 1;
            EXPDropped = EXPDropped += 1;
        }
        


    }
}
