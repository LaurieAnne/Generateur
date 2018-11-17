using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generateur
{
    public class Usine
    {
        public static Usine m_usine; //Usine?????
        
        public Usine() //Constructeur????
        {
            if (m_usine == null)
            {
                m_usine = new Usine(); //????????????????????????
            }
        }
    }
}
