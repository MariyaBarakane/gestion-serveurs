using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Go
    {
        private int valeur; 
        private static string symbole="GO";

        public Go() { }
        public Go(int val)
        {
            this.valeur = val;

        }
        public  string Tostring()
        {
            string s;
            s = this.valeur + symbole;
            return s;
        }
    }
}
