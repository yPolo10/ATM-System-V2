using System;
using System.Net.NetworkInformation;

namespace ATM_System_V2.src
{
    class Accounts
    {
        protected int Id;

        public int UserId;

        protected string VorName;

        protected string NachName;

        protected int Pin;

        protected int Bal;

        protected bool IsAdmin;

        // Konstruktor
        public static int numberOfAccounts;

        public Accounts(int id, int userid, int pin, int bal, bool isadmin, string vorName, string nachName)
        {
            Id = id;
            UserId = userid;
            Pin = pin;
            Bal = bal;
            IsAdmin = isadmin;
            VorName = vorName;
            NachName = nachName;

            numberOfAccounts++;

        }

        //GETTER
        public int GetId(Accounts a)
        {
            return a.Id;
        }
        public int GetUserIdByName(Accounts a)
        {
            return a.UserId;
        }
        public int GetUserId()
        {
            return UserId;
        }
        public int GetPin()
        {
            return Pin;
        }
        public int GetBal(Accounts a)
        {
            return a.Bal;
        }
        public bool GetAdminStatus(Accounts a)
        {
            return a.IsAdmin;
        }
        public string GetVorName()
        {
            return VorName;
        }
        public string GetNachName()
        {
            return NachName;
        }
        public string GetFullName()
        {
            return VorName + " " + NachName;
        }

        //SETTER

        public void SetId(Accounts a, int id)
        {
            a.Id = id;
        }
        public void SetUserId(Accounts a, int userId)
        {
            a.UserId = userId;
        }
        public void SetPin(Accounts a, int pin)
        {
            a.Pin = pin;
        }
        public void SetBal(Accounts a, int bal)
        {
            a.Bal = bal;
        }
        public void SetAdminStatus(Accounts a, bool admin)
        {
            a.IsAdmin = admin;
        }
        public void SetVorName(Accounts a, string vorName)
        {
            a.VorName = vorName;
        }
        public void SetNachName(Accounts a, string nachName)
        {
            a.NachName = nachName;
        }
    }

    //ADMIN ACCOUNT

    class AdminAccount : Accounts
    {
        protected string AdminPin { get; set; }

        public AdminAccount(int id, int userid, int pin, int bal, bool isadmin, string adminPin, string VorName, string NachName) : base(id, userid, pin, bal, isadmin, VorName, NachName)
        {
            AdminPin = adminPin;

        }

        //GETTER
        public static string GetAdminPin(AdminAccount ac)
        {
            return ac.AdminPin;
        }

        //SETTER
        public static void SetAdminPin(AdminAccount ac, string adminPin)
        {
            ac.AdminPin = adminPin;
        }

    }
}
