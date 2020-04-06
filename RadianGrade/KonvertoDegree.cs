using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianGrade
{
   public static class KonvertoDegree1
    {
        public static double KonvertoDegree(double radian)
        {
            double pi = 3.14159;
            return (radian * (180 / pi));
        }
    }
}
