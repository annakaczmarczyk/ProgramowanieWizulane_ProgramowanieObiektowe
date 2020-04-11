using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIAGRAM_KLAS_ZADANIE
{
    public class Liczby
    {
        protected int a;
        protected int b;
        protected int c;

        public Liczby()
        {
            
            a = b = c = 0;
        }

        public void dostep_do_a(int a)
        {
            this.a = a;
        }

        public void dostęp_do_b(int b)
        {
            this.b=b;
        }

        public void dostęp_do_c(int c)
        {
            this.c=c;
        }
    }
}