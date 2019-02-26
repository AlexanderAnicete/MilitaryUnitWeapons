using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Weapons
    {
        public string weaponName;

        public void Sound()
        {
            Console.WriteLine("This guns sounds goes pow pow pow");
        }
        public virtual void NumOfParts()
        {
        }
        public virtual void GunType()
        {
        }
    }

    public class Pistol : Weapons
    {
        public void NameOfWeapon(string aWeaponName)
        {
            weaponName = aWeaponName;
        }

        public override void NumOfParts()
        {
            Console.WriteLine("The M9 Pistol has 20 parts.");
        }
        public override void GunType()
        {
            Console.WriteLine("This weapon is an M9 Pistol.");
        }
    }

    public class Rifle : Pistol
    {
        public override void NumOfParts()
        {
            Console.WriteLine("The M16 Rifle has 50 parts.");
        }
        public override void GunType()
        {
            Console.WriteLine("This weapon is an M16 Rifle.");
        }
    }

    public class MachineGun : Rifle
    {
        public override void NumOfParts()
        {
            Console.WriteLine("The M240 Machine Gun has 100 parts.");
        }
        public override void GunType()
        {
            Console.WriteLine("This weapon is an M240 Machine Gun.");
        }
    }
}
