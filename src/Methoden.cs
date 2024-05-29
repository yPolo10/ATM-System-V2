using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System_V2.src
{
    class Methoden
    {

        public Methoden() { }


        public static void UserLogin()
        {

            int userId;
            int pin;

            Accounts currentUser;

            // CHECK FOR USER ID
            while (true)
            {
                try
                {
                    Console.WriteLine("----- ATM-System -----");
                    Console.WriteLine(" ");
                    Console.WriteLine("UserID: ");
                    Console.SetCursorPosition(9, 2);
                    userId = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------");

                    currentUser = ATM.accounts.FirstOrDefault(a => a.UserId == userId);
                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Die UserID: " + userId + " wurde nicht im System gefunden!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine("UserID nicht gefunden!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    UserLogin();
                }

            }

            //PIN CHECK
            while (true)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("----- ATM-System -----");
                    Console.WriteLine(" ");
                    Console.WriteLine("UserID: " + currentUser.GetUserId());
                    Console.WriteLine(" ");
                    Console.WriteLine("PIN: ");
                    Console.SetCursorPosition(6, 4);
                    pin = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------");

                    currentUser = ATM.accounts.FirstOrDefault(a => a.UserId == userId);
                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Falscher PIN!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Falscher PIN!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    UserLogin();
                }
            }

            // IF Login Pass: PersonalMenu();
            Console.Clear();
            Console.WriteLine("Willkommen!" + currentUser.GetFullName());
            //CurrentUserMenu();

        }


        // Second Window
        public static void SelectLoginMenu()
        {
            string input;

            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("(1) - User Login");
            Console.WriteLine("(2) - Admin Login");
            Console.WriteLine(" ");
            Console.WriteLine("(3) - Zurück");
            Console.WriteLine("(4) - Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Auswahl: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");
            Console.SetCursorPosition(9, 8);
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    UserLogin();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Admin Login");
                    break;
                case "3":
                    Console.Clear();
                    SelectLoginRegisterMenu();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Option!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    SelectLoginRegisterMenu();
                    break;
            }

        }

        // First window
        public static void SelectLoginRegisterMenu()
        {
            string input;

            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("(1) - Login");
            Console.WriteLine("(2) - Register (soon)");
            Console.WriteLine(" ");
            Console.WriteLine("Auswahl: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");
            Console.SetCursorPosition(9, 5);
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    SelectLoginMenu();
                    break;
                case "2":
                    Console.WriteLine("Register");
                    break;
                default:
                    Console.WriteLine("Ungültige Option!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    SelectLoginRegisterMenu();
                    break;
            }
        }
    }
}
