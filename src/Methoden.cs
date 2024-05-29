using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System_V2.src
{
    class Methoden
    {
        public Methoden() { }

        public static void AdminLogin()
        {
            int cooldown = 1000;

            int userId;
            string adminpin;

            Accounts currentUser;

            // CHECK FOR USER ID
            Console.Clear();
            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("UserID: ");
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------");

            while (true)
            {
                try
                {
                    Console.SetCursorPosition(9, 2);
                    userId = int.Parse(Console.ReadLine());

                    currentUser = ATM.accounts.FirstOrDefault(a => a.UserId == userId);

                    if (currentUser.GetAdminStatus() == false)
                    {
                        Console.Clear();
                        SelectLoginRegisterMenu();
                    }

                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Die UserID: " + userId + " wurde nicht im System gefunden!!");
                        Thread.Sleep(cooldown);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Die ID muss aus Zahlen bestehen!");
                    Thread.Sleep(cooldown);
                    Console.Clear();
                    UserLogin();
                }
            }

            //PIN CHECK
            Console.Clear();
            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("UserID: " + currentUser.GetUserId());
            Console.WriteLine(" ");
            Console.WriteLine("PIN: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");

            while (true)
            {
                try
                {
                    Console.SetCursorPosition(6, 4);
                    adminpin = Console.ReadLine();

                    if (currentUser.GetAdminPin() == adminpin) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Falscher PIN!");
                        Thread.Sleep(cooldown);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Falscher PIN!");
                    Thread.Sleep(cooldown);
                    Console.Clear();
                    UserLogin();
                }
            }

            // IF Login Pass: PersonalMenu();
            Console.Clear();
            Console.WriteLine("Willkommen!");
            //CurrentUserMenu();
        }


        public static void UserLogin()
        {
            int cooldown = 1000;

            int userId;
            int pin;

            Accounts currentUser;

            // CHECK FOR USER ID
            Console.Clear();
            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("UserID: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");

            while (true)
            {
                try
                {
                    Console.SetCursorPosition(9, 2);
                    userId = int.Parse(Console.ReadLine());

                    currentUser = ATM.accounts.FirstOrDefault(a => a.UserId == userId);
                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Die UserID: " + userId + " wurde nicht im System gefunden!!");
                        Thread.Sleep(cooldown);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Die ID muss aus Zahlen bestehen!");
                    Thread.Sleep(cooldown);
                    Console.Clear();
                    UserLogin();
                }
            }

            //PIN CHECK
            Console.Clear();
            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("UserID: " + currentUser.GetUserId());
            Console.WriteLine(" ");
            Console.WriteLine("PIN: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");

            while (true)
            {
                try
                {
                    Console.SetCursorPosition(6, 4);
                    pin = int.Parse(Console.ReadLine());

                    if (currentUser.GetPin() == pin) { break; }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Falscher PIN!");
                        Thread.Sleep(cooldown);
                        Console.Clear();
                        UserLogin();
                    }
                }
                catch
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Falscher PIN!");
                    Thread.Sleep(cooldown);
                    Console.Clear();
                    UserLogin();
                }
            }

            // IF Login Pass: PersonalMenu();
            Console.Clear();
            Console.WriteLine("Willkommen!");
            //CurrentUserMenu();
        }


        // Second Window
        public static void SelectLoginMenu()
        {
            string input;

            Console.WriteLine("----- ATM-System -----");
            Console.WriteLine(" ");
            Console.WriteLine("(1) - User Login");
            Console.WriteLine(" ");
            Console.WriteLine("(2) - Zurück");
            Console.WriteLine("(3) - Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Auswahl: ");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------");
            Console.SetCursorPosition(9, 7);
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    UserLogin();
                    break;
                case "888":
                    Console.Clear();
                    AdminLogin();
                    break;
                case "2":
                    Console.Clear();
                    SelectLoginRegisterMenu();
                    break;
                case "3":
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
