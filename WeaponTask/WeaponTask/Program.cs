using System;
using WeaponTask.Models;

namespace WeaponTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity;

            do
            {
                Console.WriteLine("Enter the maximum bullet capacity:");
                bulletCapacity = Convert.ToInt32(Console.ReadLine());

            } while (bulletCapacity<=0 || bulletCapacity>120);

            int bulletCount;

            do
            {
                Console.WriteLine("Enter the bullets:");
                bulletCount = Convert.ToInt32(Console.ReadLine());

            } while (bulletCount <=0 || bulletCount > bulletCapacity);

            Weapon weapon = new Weapon(bulletCapacity,bulletCount);

            int choice;

            do
            {
                Console.WriteLine("Choose the command (0: Info)");

                /*Another variant of menu:*/

                //Console.WriteLine("0: Info\n" +
                //    "1: Shoot\n" +
                //    "2: Fire\n" +
                //    "3: Remain Bullet Count\n" +
                //    "4: Reload\n" +
                //    "5: Change Fire Mode\n" +
                //    "6: Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("------------------------");
                        Console.WriteLine(
                    "1: Shoot\n" +
                    "2: Fire\n" +
                    "3: Remain Bullet Count\n" +
                    "4: Reload\n" +
                    "5: Change Fire Mode\n" +
                    "6: Exit\n" +
                    "7: Edit");
                        Console.WriteLine("------------------------");
                        break;
                    case 1:
                        Console.WriteLine("------------------------");
                        weapon.Shoot();
                        Console.WriteLine("------------------------");
                        break;
                    case 2:
                        Console.WriteLine("------------------------");
                        weapon.Fire();
                        Console.WriteLine("------------------------");
                        break;
                    case 3:
                        Console.WriteLine("------------------------");
                        Console.WriteLine($"You need {weapon.GetRemainBulletCount()} bullets for reload");
                        Console.WriteLine("------------------------");
                        break;
                    case 4:
                        Console.WriteLine("------------------------");
                        weapon.Reload();
                        Console.WriteLine("------------------------");
                        break;
                    case 5:
                        Console.WriteLine("------------------------");
                        weapon.ChangeFireMode();
                        Console.WriteLine("------------------------");
                        break;
                    case 7:
                        Console.WriteLine("Choose the command: (Q : exit)");
                        char editChoice;
                        do
                        {
                            editChoice = Convert.ToChar(Console.ReadLine().ToUpper());
                            switch (editChoice)
                            {
                                case 'T':
                                    int changedBulletCapacity;
                                    do
                                    {
                                        Console.WriteLine("Enter the maximum bullet capacity:");
                                        changedBulletCapacity = Convert.ToInt32(Console.ReadLine());

                                    } while (changedBulletCapacity <= 0 || changedBulletCapacity > 120);
                                    weapon.ChangeBulletCapacity(changedBulletCapacity);
                                    break;
                                case 'S':
                                    Console.WriteLine("gulle sayi");
                                    break;
                                case 'D':
                                    Console.WriteLine("saniye");
                                    break;
                            }
                        } while (editChoice != 'Q');
                        break;
                    default:
                        break;
                }
            } while (choice != 6);
        }
    }
}
