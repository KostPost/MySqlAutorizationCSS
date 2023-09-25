using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlAutorizationCSS
{
    class Program
    {
        static void Main(string[] args)
        {

            Account controller = new Account();

            controller.FindByName("qwe");

        }

    }
}
