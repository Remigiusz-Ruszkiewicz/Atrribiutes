using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrribiutes
{
    class Program
    {
        static void Main(string[] args)
        {
            CondictionalClass conditionalclass = new CondictionalClass();
            
            
#if DEBUG
            conditionalclass.Login();

#else
            conditionalclass.Login("user","pass");
#endif
            Console.Read();
        }
        
    }
}
