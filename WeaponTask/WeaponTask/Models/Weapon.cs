using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponTask.Models
{
    public class Weapon
    {
        private int _bulletCapacity;

        public int BulletCapacity { 
            get 
            {
                return _bulletCapacity;
            } 
            set 
            { 
                if(value > 0 && value <= 120)
                {
                    _bulletCapacity = value;
                }
            } 
        }
        public int CurrentBulletCount { get; set; }
        public double DisChargeTime { get; set; }
        public bool FireMode { get; set; }

        public Weapon()
        {

        }

        public Weapon(int bulletCapacity,int bulletCount)
        {
            this.BulletCapacity = bulletCapacity;
            this.CurrentBulletCount = bulletCapacity;
        }

        // Shoot Method

        public void Shoot()
        {
            if(CurrentBulletCount > 0)
            {
                --CurrentBulletCount;
                Console.WriteLine("1 bullet shot!");
            }
            else
            {
                Console.WriteLine("You don't have any bullet in your magazine.");
            }
        }

        // Fire Method

        public void Fire()
        {
            if (CurrentBulletCount > 0)
            {
                if (FireMode == true)
                {
                    double fireTime = (CurrentBulletCount * DisChargeTime) / BulletCapacity; 
                    CurrentBulletCount = 0;

                    Console.WriteLine(Math.Round(fireTime,2) + " sec");
                }
                else
                {
                    --CurrentBulletCount;
                    Console.WriteLine("1 bullet shot");
                }
            }
            else
            {
                Console.WriteLine("You don't have any bullet in your magazine.");
            }
        }

        // Get Remain Bullet Count Method

        public int GetRemainBulletCount()
        {
            return BulletCapacity - CurrentBulletCount;
        }

        // Reload Method

        public void Reload()
        {
            if(BulletCapacity != CurrentBulletCount)
            {
                int neededBullets = GetRemainBulletCount();
                CurrentBulletCount += neededBullets;

                Console.WriteLine($"Reloaded! Added {neededBullets} bullets to magazine.");
            }
            else
            {
                Console.WriteLine("You don't need reload.");
            }
        }


        // Change Fire Mode

        public void ChangeFireMode()
        {
            if (FireMode == true)
            {
                FireMode = false;
                Console.WriteLine("Single mode activated");
            }
            else
            {
                FireMode = true;
                Console.WriteLine("Auto mode activated");

            }
        }

        // Change Bullet Capacity
        public void ChangeBulletCapacity(int newBulletCapacity)
        {
            this.BulletCapacity = newBulletCapacity;
            this.CurrentBulletCount = _bulletCapacity;
            Console.WriteLine($"Your new bullet capacity is {_bulletCapacity}");
        }
    }
}
