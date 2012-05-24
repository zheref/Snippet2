using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snippet2.Model
{
    public class Tecnologia
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Source { get; set; }

        List<Solucion> _soluciones = null;

        public List<Solucion> Soluciones
        {
            get
            {
                //process
                return _soluciones;
            }
        }
    }
}
