#define OTHER
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrribiutes
{
    class CondictionalClass
    {
        //[Conditional("DEBUG")]
        public void Login()
        {
            showUI();
        }
        //[Conditional("OTHER")]
        public void Login(string user,string password)
        {
           
            LoginPage();
            Console.WriteLine("1");
        }

        private void LoginPage()
        {
            
            LoginPage2();
            Console.WriteLine("2");
        }

        private void LoginPage2()
        {
            showUI();
        }

        private void showUI()
        {
            Console.WriteLine("Witaj");
        }
    }
}
