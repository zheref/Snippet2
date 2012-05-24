using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Snippet2.Model
{
	public class Snippet
	{
        public Snippet() { }

        public Snippet(int id, string nombre, string desc, DateTime fecha)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Descripcion = desc;
            this.Fecha = fecha;
        }

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        DateTime Fecha { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
	}
}