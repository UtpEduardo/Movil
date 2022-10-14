using System;
using System.Collections.Generic;
using System.Text;

namespace Producto1.Models
{
    public class Medicamentos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public DateTime FechaCaducida { get; set; }
        public double Precio { get; set; }
        public string Imagen {  get; set; }
        public bool Promocion {  get; set; }
    }
}
