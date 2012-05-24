using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using Snippet2.Model;

namespace Snippet2.DAL
{
    public class DBSnippetContext : DBDataContext<Snippet>
    {
        public override int Insert(Snippet snippet)
        {
            string strquery = @"insert into SNIPPET (SNI_NOMBRE, SNI_DESCRIP, SNI_FECHA, SNI_ESTADO)
                                values (
						                    N'" + snippet.Nombre + @"', 
						                    N'" + snippet.Descripcion + @"', 
						                    GETDATE(), 
						                    N'A'
					                   );";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
            return 0;
        }

        public override List<Snippet> SelectAll()
        {
            string strquery = @"select * from SNIPPET";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Snippet> results = new List<Snippet>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Snippet snip = new Snippet
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(snip);
                }
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results.ToList<Snippet>();
        }

        public override void Delete(Snippet snippet)
        {
            string strquery = @"delete from SNIPPET
                                where SNI_ID = " + snippet.ID + ";";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
        }

        public override void Update(Snippet snippet)
        {
            string strquery = @"update SNIPPET
                                set SNI_NOMBRE = '" + snippet.Nombre + @"',
                                SNI_DESCRIP = '" + snippet.Descripcion + @"',
                                SNI_FECHA = GETDATE()
                                where SNI_ID = " + snippet.ID + ";";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
        }

        internal override List<Snippet> Select(string key)
        {
            string strquery = @"select * from SNIPPET where SNI_DESCRIP like '%" + key + @"%';";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Snippet> results = new List<Snippet>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Snippet snip = new Snippet
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(snip);
                }
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results.ToList<Snippet>();
        }

        internal List<Snippet> Select(Categoria cat)
        {
            string strquery = @"SELECT        SNIPPET.SNI_ID, SNIPPET.SNI_NOMBRE, SNIPPET.SNI_DESCRIP, SNIPPET.SNI_FECHA, SNIPPET.SNI_ESTADO, CATEGORIA.CAT_NOMBRE
FROM            SNIPPET CROSS JOIN
                         CATEGORIA_DETAIL INNER JOIN
                         CATEGORIA ON CATEGORIA_DETAIL.SNI_ID = SNIPPET.SNI_ID AND CATEGORIA_DETAIL.CAT_ID = CATEGORIA.CAT_ID
WHERE        (CATEGORIA.CAT_ID = " + cat.ID.ToString() + @")";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Snippet> results = new List<Snippet>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Snippet snip = new Snippet
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(snip);
                }
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results.ToList<Snippet>();
        }

        public int Insert(Snippet snippet, Categoria cat)
        {
            string strquery = @"insert into CATEGORIA_DETAIL (SNI_ID, CAT_ID)
                                values (
						                    " + snippet.ID + @", 
						                    " + cat.ID + @"
					                   );";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
            return 0;
        }
    }
}
