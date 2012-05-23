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
using System.Data;
using System.Data.SqlClient;

using Snippet2.DAL;

namespace Snippet2
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DBConnecter db = new DBConnecter();
		DBSnippetContext context = new DBSnippetContext();

		public MainWindow()
		{
			this.InitializeComponent();
		}

		private void btnCargar_Click(object sender, RoutedEventArgs e)
		{
			Refresh();
		}

		private void Refresh()
		{
			grdContainer.Children.Clear();
			SnippetList list = new SnippetList()
			{
				Snippets = context.SelectAll()
			};
			list.Actualizar += new EventHandler<SnippetEventArgs>(btnActualizar_Click);
			list.Eliminar += new EventHandler<SnippetEventArgs>(btnEliminar_Click);
			grdContainer.Children.Add(list);
		}

        private void Search(string key)
        {
            grdContainer.Children.Clear();
            SnippetList list = new SnippetList()
            {
                Snippets = context.Select(key)
            };
            list.Actualizar += new EventHandler<SnippetEventArgs>(btnActualizar_Click);
            list.Eliminar += new EventHandler<SnippetEventArgs>(btnEliminar_Click);
            grdContainer.Children.Add(list);
        }

		private void btnActualizar_Click(object sender, SnippetEventArgs args)
		{
			Snippet result = args.Result;
			grdContainer.Children.Clear();
			SnippetEdit edition = new SnippetEdit()
			{
				Snippet = result,
				Way = EditingWay.UPDATING
			};
			grdContainer.Children.Add(edition);
			edition.Confirmed += new EventHandler<SnippetEventArgs>(update_Confirmed);
		}

		private void btnEliminar_Click(object sender, SnippetEventArgs args)
		{
			Snippet result = args.Result;
			context.Delete(result);
			Refresh();
		}

		private void mniNuevo_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			grdContainer.Children.Clear();
			SnippetEdit edition = new SnippetEdit();
			grdContainer.Children.Add(edition);
			edition.Confirmed += new EventHandler<SnippetEventArgs>(edition_Confirmed);
		}

		void edition_Confirmed(object sender, SnippetEventArgs args)
		{
			Snippet result = args.Result;
			int r = context.Insert(result);
			MessageBox.Show("Se guardo el registro " + r);
		}

		void update_Confirmed(object sender, SnippetEventArgs args)
		{
			Snippet result = args.Result;
			context.Update(result);
			Refresh();
		}

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Search(txtKeywordsToSearch.Text);
        }
	}
}