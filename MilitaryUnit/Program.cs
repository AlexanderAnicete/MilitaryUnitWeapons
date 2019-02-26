using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Pistol p1 = new Pistol();
            p1.NameOfWeapon("Sally");
            p1.GunType();
            p1.NumOfParts();
            Console.WriteLine("This weapons name is "+ p1.weaponName);
            Console.ReadKey();
            Console.Clear();

            Rifle p2 = new Rifle();
            p2.NameOfWeapon("Ariel");            
            p2.GunType();
            p2.NumOfParts();
            Console.WriteLine("This weapons name is " + p2.weaponName);
            Console.ReadKey();
            Console.Clear();

            MachineGun p3 = new MachineGun();
            p3.NameOfWeapon("Maria");
            p3.GunType();
            p3.NumOfParts();
            Console.WriteLine("This weapons name is " + p3.weaponName);
            p2.Sound();
            Console.ReadKey();
            Console.Clear();

            H60RHelicopters h1 = new H60RHelicopters("Woooosh!", "1000 mph", "50 caliber bullets");
            Console.WriteLine("H60 Helicopters goes " + h1.engineSound + ", flies at " + h1.speed + ", and shoots " + h1.shoots + ".");

            FA18Jets j1 = new FA18Jets("wop wop wop!", "200 mph", "missiles");
            Console.WriteLine("FA18 Jets goes " + j1.engineSound + ", flies at " + j1.speed + ", and shoots " + j1.shoots + ".");
        }
    }
}
