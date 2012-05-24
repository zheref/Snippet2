using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Snippet2.Model;

namespace Snippet2.DAL
{
    public class DBCategoriaDataContext : DBDataContext<Categoria>
    {

        public override int Insert(Categoria insertion)
        {
            throw new NotImplementedException();
        }

        public override List<Categoria> SelectAll()
        {
            throw new NotImplementedException();
        }

        public override void Delete(Categoria deleting)
        {
            throw new NotImplementedException();
        }

        public override void Update(Categoria updating)
        {
            throw new NotImplementedException();
        }

        internal override List<Categoria> Select(string key)
        {
            throw new NotImplementedException();
        }
    }
}
