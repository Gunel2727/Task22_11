using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class Weapon
    {
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }
        public int DischargeTime { get; set; }
        public FireMode FireMode { get; set; }
        public Weapon(int bulletCapacity, int bulletCount,FireMode fireMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            FireMode = fireMode;
        }
        public void Shoot()
        {
            if (BulletCount > 0)
            {
                BulletCount--;
                Console.WriteLine("Bang!");
            }
            else
            {
                Console.WriteLine("No bullets left!");
            }
        }
      public void Fire()
        {
            if (FireMode == FireMode.Single)
            {
                Shoot();
                DischargeTime++;
            }
            else if (FireMode == FireMode.Auto)
            {
                while (BulletCount > 0)
                {
                    Shoot();
                    DischargeTime++;
                }
            }
            Console.WriteLine($"Total shots fired: {DischargeTime}");
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine($"Number of needed bullets to full the weapon: {BulletCapacity - BulletCount}");
        }
        public void Reload()
        {
            BulletCount = BulletCapacity;
            Console.WriteLine("Weapon reloaded.");
        }
        public void ChangeFireMode()
        {
            if(FireMode==FireMode.Single)
            {
                FireMode = FireMode.Auto;
                Console.WriteLine("Fire mode changed to Auto.");
            }
            else
            {
                FireMode = FireMode.Single;
                Console.WriteLine("Fire mode changed to Single.");
            }
        }

    }
            
}
