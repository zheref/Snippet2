using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snippet2.Model
{
    public class Categoria
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        private List<Snippet> _snippets;

        public List<Snippet> Snippets
        {
            get;
            set;
        }
    }
}
