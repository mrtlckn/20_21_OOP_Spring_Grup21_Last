using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    class User
    {
        public string[] Username = { "admin","user"};
        public string[] Password = { "admin", "user" };


       

        
        public bool Control(string name,string pass)
        {
            for (int i = 0; i < 1; i++)
            {
                if (Username[i] == name && Password[i] == pass)
                    return true;

            }
            return false;
        }

    }
}
