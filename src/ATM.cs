using ATM_System_V2.src;
using System;
using System.Collections.Concurrent;

class ATM
{

    public static List<Accounts> accounts { get; set; } = new List<Accounts>();

    
    static void Main(string[] args)
    {

        accounts.Add(new Accounts(1, 10, 1234, 0, false, "Milan", "Ramos"));
        accounts.Add(new AdminAccount(2, 20, 1234, 1000, true, "Ingo1234", "Heike", "Pistorius"));

        Methoden.SelectLoginRegisterMenu();

    }



}