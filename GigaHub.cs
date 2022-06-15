using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class GigaHub
    {
        private List<SERVEUR> s; 
        public GigaHub() {

            s = new List<SERVEUR>();
        
        }
        public void addserveur(ServeurST s, ServeurWeb SW)
        {
            this.s.Add(s);
            this.s.Add(SW);
        }
    }
}
