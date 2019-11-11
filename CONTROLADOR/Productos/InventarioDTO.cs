using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR.Productos
{
    public class InventarioDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public int idcategoria { get; set; }
        public int estado { get; set; }
    }
}
