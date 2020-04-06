using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadianGrade
{
    class Komnvertimi1
    {
        public class Konvertimi
        {
 
            static void Main(string[] args)
            {
                Console.WriteLine("Jep radianin:");
                double radian = Convert.ToDouble (Console.ReadLine());
                //double radian = 5.0;
                double degree = KonvertoDegree1.KonvertoDegree(radian);
                Console.WriteLine("degree = " + degree);

            // Konvertimi i Degree ne Radian
                Console.WriteLine("Jep Degree:");
                degree = Convert.ToDouble(Console.ReadLine());
                radian = KonvertoRad.KonvertoRadian(degree);
                Console.WriteLine("Radian=" + radian);
                  Console.ReadKey();
            }
       
           
        }
       
    }
     
}
