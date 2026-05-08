using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroduccionCsharp.Models
{
    public class Distancia
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double Res {  get; set; }

        public void Operacion()
        {
            double baseTriangulo = this.x2 - this.x1;
            double alturaTriangulo = this.y2 - this.y1;

            double sumaCuadrados = (baseTriangulo * baseTriangulo) + (alturaTriangulo * alturaTriangulo);

            this.Res = Math.Sqrt(sumaCuadrados);
        }

    }
}