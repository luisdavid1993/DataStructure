using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDinamic
{
   public class Cnodo
    {
        private string dato;
        private Cnodo hijo;
        private Cnodo hermano;

        public string Dato { get; set; }
        public Cnodo Hijo { get; set; }
        public Cnodo Hermano { get; set; }

        public Cnodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
