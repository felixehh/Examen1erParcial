using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        public List<Ingredientes> ingredientes;
        public Platillos platillos = new Platillos();
    }
}
