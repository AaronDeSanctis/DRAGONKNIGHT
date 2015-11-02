using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAGON_KNIGHT
{
    public class Weapon
    {

        public int DMG;
        //public int MagDMG;
        public int sword;
        public int iceBlade;
        public int chaosBlade;
        public int excalibur;
        public string equipped;
        public List<string> WeaponList;
        public Weapon()
        {
            DMG = 0;
            sword = 5;
            iceBlade = 15;
            chaosBlade = 30;
            excalibur = 50;
            equipped = "";
            WeaponList = new List<string>();
        }
        public bool GetSword()
        {
            DMG += sword;
            return true;
        }
        public bool GetIceBlade()
        {
            DMG += iceBlade;
            return true;
        }

        public bool WeaponSelect(string weaponName)
        {
            if (weaponName == "Sword")
            {
                equipped = weaponName;
                GetSword();
                return true;

            }
            if (weaponName == "IceBlade")
            {
                equipped = weaponName;
                GetIceBlade();
                return true;
            }
            return false;
        }
    }
}
