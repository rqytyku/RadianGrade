using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianGrade
{
    public static class KonvertoRad
    {
        public static double KonvertoRadian(double degree)
        {
            double radians = (Math.PI / 180) * degree;
            return (radians);
        }
    }
}
