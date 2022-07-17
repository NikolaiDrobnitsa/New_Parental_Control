using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Parental_Control.Controller
{
    internal class AuthController
    {
        public AuthController()
        {

        }
        public bool Authorization(string Auth_pass)
        {
            return Auth_pass == "1111";
        }
    }
    
}
