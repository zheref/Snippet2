using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Snippet2.View;

namespace Snippet2.DAL
{
    public class DBConnecter
    {
        private const string FILE_LOCATION = @"E:\DATA\CodeSynchro\Snippet2\Snippet2\Database\SnippetDB.mdf";
        private readonly string CONNECTION_STR = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + FILE_LOCATION + ";User Instance=True";
        private const string CONNECTION = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\DATA\CodeSynchro\Snippet2\Snippet2\Database\SnippetDB.mdf;Integrated Security=True;User Instance=True";
        //private const string CONNECTION = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\DATA\CodeSynchro\Snippet2\Snippet2\Database\SnippetDB.mdf;Integrated Security=True;User Instance=True";

        internal static SqlConnection Connection;

        static DBConnecter()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = CONNECTION;
            try
            {
                Connection.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*
            finally
            {
                connection.Close();
            }*/
        }

        public IOperationNotifier Notifier { private get; set; }

        public DBConnecter(IOperationNotifier not)
        {
            Notifier = not;
        }

        public IEnumerable<string> Load(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> results = new List<string>();
            if (reader.HasRows)
                while (reader.Read())
                    results.Add(reader.GetString(1));
            else
                Console.WriteLine("No rows returned.");
            reader.Close();
            return results;
        }
    }
}
