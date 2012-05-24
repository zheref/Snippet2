using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Snippet2.Model;
using System.Data.SqlClient;

namespace Snippet2.DAL
{
	public class DBKeywordDataContext : DBDataContext<Keyword>
	{
		public override int Insert(Keyword insertion)
		{
            /*
			string strquery = @"insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
								values (
											N'" + snippet.Nombre + @"', 
											N'" + snippet.Descripcion + @"', 
											GETDATE(), 
											N'A'
									   );";
			SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
			cmd.ExecuteScalar();
            */
			return 0;
		}

		public override List<Keyword> SelectAll()
		{
			throw new NotImplementedException();
		}

		public override void Delete(Keyword deleting)
		{
			throw new NotImplementedException();
		}

		public override void Update(Keyword updating)
		{
			throw new NotImplementedException();
		}

		internal override List<Keyword> Select(string key)
		{
			throw new NotImplementedException();
		}
	}
}
