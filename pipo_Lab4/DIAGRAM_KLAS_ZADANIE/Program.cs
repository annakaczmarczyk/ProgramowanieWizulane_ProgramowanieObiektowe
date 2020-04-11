using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAGRAM_KLAS_ZADANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            Liczby L1 = new Liczby();
            Liczby L2 = new Liczby();

            L1.dostep_do_a(45);
            L1.dostęp_do_b(11);
            L1.dostęp_do_c(33);

            L2.dostep_do_a(85);
            L2.dostęp_do_b(44);
            L2.dostęp_do_c(39);

            Lepsze_liczby LL1 = new Lepsze_liczby();
            LL1.dostep_do_a(43);
            LL1.dostęp_do_b(33);
            LL1.dostęp_do_c(77);
        }
    }
}
