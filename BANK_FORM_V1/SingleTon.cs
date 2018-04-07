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
    }
}
