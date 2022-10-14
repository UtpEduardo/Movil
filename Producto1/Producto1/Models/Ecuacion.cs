using System;
using System.Collections.Generic;
using System.Text;

namespace Producto1.Models
{
    public class Ecuacion
    {
        public double a=0, b=0, c=0, x1=0, x2=0;

        public string SEcuacioX1()
        {
            double formula = 0.0;
            string msj = "";
            formula = Math.Pow(b,2) - (4 * a * c);

            if (formula <= 0)
            {
                msj = "Los Resultados son Imaginario";
            }
            else
            {
                x1=(-b - (Math.Sqrt(formula)) / (2*a));
                
                msj = x1.ToString();
            }
            return msj;
        }

        public string SEcuacioX2()
        {
            double formula = 0.0;
            string msj = "";
            formula = (b * b) - (4 * a * c);

            if (formula <= 0)
            {
                msj = "Los Resultados son Imaginario";
            }
            else
            {
                x2 = (-b + Math.Sqrt(formula) / (2 * a));

                msj = x2.ToString();
            }
            return msj;
        }
    }
}
