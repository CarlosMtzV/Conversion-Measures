using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasConvercion
{
    internal class Conversiones
    {
        // Método
        public static double MetrosACentimetros(double metros)
        {
            return metros * 100;
        }

        // Método 
        public static double MetrosAPulgadas(double metros)
        {
            return metros * 39.3701;
        }

        // Método 
        public static double MetrosAPies(double metros)
        {
            return metros * 3.28084;
        }
    }
}
