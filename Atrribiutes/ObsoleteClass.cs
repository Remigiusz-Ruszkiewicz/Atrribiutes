using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atrribiutes
{
    public class ObsoleteClass
    {
        [Obsolete("Uzyj metody NewMethod")]
        public string OldMethod()
        {
            try
            {
                //proba podlaczenia
                throw new Exception("Serwer nie istnieje");
            }
            catch (Exception)
            {

                //logowanie problemu 
            }
            return nameof(OldMethod);
        }
        public string NewMethod()
        {
            return nameof(NewMethod);
        }
    }
}
