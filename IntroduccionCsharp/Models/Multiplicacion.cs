using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Multiplicacion
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public string Res { get; set; }

        public void SumaFor()
        {
            int resultadoNumerico = 0;
            string procesoAcumulado = "";
            int veces = Math.Abs(this.Num2);

            for (int i = 0; i < veces; i++)
            {
                resultadoNumerico += this.Num1;
                procesoAcumulado += this.Num1;

                if (i < veces - 1)
                {
                    procesoAcumulado += "+";
                }
            }

            this.Res = procesoAcumulado + "=" + resultadoNumerico;
        }
    }
}