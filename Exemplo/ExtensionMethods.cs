using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class ExtensionMethods
    {

        public static int ToInt(this string valor)
        {
            return Convert.ToInt32(valor);
        }
    }
}
