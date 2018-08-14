using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_FORM_V1
{
     public class SingleTon
    {
        private static string UserRefrensh;

        public static void SetUser(string User)
        {
            UserRefrensh = User;
        }

        public static string GetUser()
        {
            if(UserRefrensh == null)
            {
                UserRefrensh = "";
            }
            return UserRefrensh;
        }

        public static int RefreshID;

        public static void SetID(int ID)
        {
            RefreshID = ID;
        }

        public static int GetID()
        {
            if(RefreshID == null)
            {
                RefreshID = 0;
            }
            return RefreshID;
        }

        public static int Refreshaccount;

        public static void Setaccounts(int accounts)
        {
            Refreshaccount = accounts;
        }
        public static int Getaccounts()
        {
            if (Refreshaccount == null)
            {
                Refreshaccount = 0;
            }
            return Refreshaccount;
        }
    }
}
