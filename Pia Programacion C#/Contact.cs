using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Programacion_C_
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public int Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad  {get; set;} 
    }
}
