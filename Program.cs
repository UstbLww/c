using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digui
{
    class Program
    {
        public void Cout(int inVal)
        {
            if (inVal == (0))
                return;
            Cout(inVal - 1);
            Console.WriteLine("{0}", inVal);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cout(3);
        }
    }
}
