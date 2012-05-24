using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Snippet2.DAL
{
    public abstract class DBDataContext<T>
    {
        public abstract int Insert(T insertion);

        public abstract List<T> SelectAll();

        public abstract void Delete(T deleting);

        public abstract void Update(T updating);

        internal abstract List<T> Select(string key);
    }
}
