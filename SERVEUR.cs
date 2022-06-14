using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    abstract internal class SERVEUR
    {
        private string IP; 
        private Go RAM ;



        public SERVEUR() { }
        public SERVEUR(string ip, Go R)
        {
            this.IP = ip;
            this.RAM = R;
        }
       abstract public void connexion_service();
        virtual public string  info()
        {
            Console.WriteLine("les informations sont:");
            string s; 
            s=this.IP.ToString()+ this.RAM.ToString();
            return s;
            ;
        }
      
        public bool compIP(string ip) 
        {
            if (this.IP == ip)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
