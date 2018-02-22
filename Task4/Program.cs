using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmLiiga
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Team JYP = new Team("JYP", "JKL");

                Console.WriteLine(JYP.ToString());

                JYP.ShowPlayers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
