using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Snippet2.Model;
using System.Data.SqlClient;

namespace Snippet2.DAL
{
    public class DBCategoriaDataContext : DBDataContext<Categoria>
    {
        public override int Insert(Categoria insertion)
        {
            string strquery = @"insert into CATEGORIA (CAT_NOMBRE, CAT_DESCRIP)
                                values (
						                    N'" + insertion.Nombre + @"', 
						                    N'" + insertion.Descripcion + @"'
					                   );";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
            return 0;
        }

        public override List<Categoria> SelectAll()
        {
            string strquery = @"select * from CATEGORIA";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Categoria> results = new List<Categoria>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Categoria cat = new Categoria
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(cat);
                }
            else
                Console.WriteLine("No rows returned in the CATEGORIA table.");
            reader.Close();
            return results;
        }

        public override void Delete(Categoria deleting)
        {
            string strquery = @"delete from CATEGORIA
                                where CAT_ID = " + deleting.ID + ";";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
        }

        public override void Update(Categoria updating)
        {
            string strquery = @"update CATEGORIA
                                set CAT_NOMBRE = '" + updating.Nombre + @"',
                                CAT_DESCRIP = '" + updating.Descripcion + @"'
                                where CAT_ID = " + updating.ID + ";";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            cmd.ExecuteScalar();
        }

        internal override List<Categoria> Select(string key)
        {
            string strquery = @"select * from CATEGORIA where CAT_DESCRIP like '%" + key + @"%';";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Categoria> results = new List<Categoria>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Categoria cat = new Categoria
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(cat);
                }
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results;


        }

        internal List<Categoria> Select(Snippet sni)
        {
            string strquery = @"SELECT        CATEGORIA.CAT_ID, CATEGORIA.CAT_NOMBRE, CATEGORIA.CAT_DESCRIP, SNIPPET.SNI_NOMBRE
FROM            CATEGORIA CROSS JOIN
                         CATEGORIA_DETAIL INNER JOIN
                         SNIPPET ON CATEGORIA_DETAIL.SNI_ID = SNIPPET.SNI_ID AND CATEGORIA_DETAIL.CAT_ID = CATEGORIA.CAT_ID
WHERE        (SNIPPET.SNI_ID = " + sni.ID.ToString() + @");";
            SqlCommand cmd = new SqlCommand(strquery, DBConnecter.Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Categoria> results = new List<Categoria>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Categoria cat = new Categoria
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    };
                    results.Add(cat);
                }
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results;
        }
    }
}
