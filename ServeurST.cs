using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class ServeurST : SERVEUR
    {
        private string type;
        public ServeurST() { }
        public ServeurST(string ip, Go r, string type) : base(ip, r)
        {

            this.type = type;

        }

        public override void connexion_service()
        {

            Console.WriteLine("bienvenu");
            this.type.ToString();


        }
        public override string info()
        {
            base.info();
            string s;
            s = this.type.ToString();
            return s;
        }
        public static bool ping(string ip)
        {
            ServeurST st = new ServeurST();
            if (st.compIP(ip))
            {
                st.info();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
