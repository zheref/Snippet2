using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Snippet2.Model;

namespace Snippet2.ViewModel
{
    public class ListarCategoriasViewModel
    {
        public ListarCategoriasViewModel()
        {
            
        }

        private void Refresh()
        {

        }

        public List<Categoria> Categorias { get; set; }
    }
}
