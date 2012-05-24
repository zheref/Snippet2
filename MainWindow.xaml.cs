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
using Snippet2.Model;
using Snippet2.View;

namespace Snippet2
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IOperationNotifier
	{
		DBConnecter db;
		DBSnippetContext context = new DBSnippetContext();
        DBCategoriaDataContext cat_context = new DBCategoriaDataContext();

        bool ActiveCategorySearch = false;

		public MainWindow()
		{
			this.InitializeComponent();
            Refresh();
            NotifyStream = new StringBuilder();
            CargarCategorias();
		}

		private void btnCargar_Click(object sender, RoutedEventArgs e)
		{
			Refresh();
		}

        /// <summary>
        /// Actualiza y muestra la lista de Snippets
        /// </summary>
		private void Refresh()
		{
			grdContainer.Children.Clear();
			SnippetList list = new SnippetList()
			{
				Snippets = context.SelectAll()
			};
			list.Actualizar += new EventHandler<SnippetEventArgs>(btnActualizar_Click);
			list.Eliminar += new EventHandler<SnippetEventArgs>(btnEliminar_Click);
            list.Ver += new EventHandler<SnippetEventArgs>(btnVer_Click);
            grdContainer.Children.Add(list);
            
		}

		/// <summary>
		/// Busca basado en la palabra clave pasada como parametro
		/// </summary>
		/// <param name="key"></param>
		private void Search(string key)
		{
			grdContainer.Children.Clear();
			SnippetList list = new SnippetList()
			{
				Snippets = context.Select(key)
			};
			list.Actualizar += new EventHandler<SnippetEventArgs>(btnActualizar_Click);
			list.Eliminar += new EventHandler<SnippetEventArgs>(btnEliminar_Click);
            list.Ver += new EventHandler<SnippetEventArgs>(btnVer_Click);
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

        private void CargarCategorias()
        {
            DBCategoriaDataContext catContext = new DBCategoriaDataContext();
            List<Categoria> categorias = catContext.SelectAll();
            foreach (Categoria cat in categorias)
                lstCategorias.Items.Add(cat);
        }

        public void Notify(string msg)
        {
            NotifyStream.AppendLine(msg);
            txtNotifier.Text = NotifyStream.ToString();
        }


        public StringBuilder NotifyStream
        {
            get;
            set;
        }

        private void Window_Initialized(object sender, System.EventArgs e)
        {
            
        }

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void btnBuscarCategoria_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            lstCategorias.Items.Clear();
            lstCategorias.Items.Add("(Ver todos)");
            lstCategorias.Items.Add("(Borrar busqueda)");
            List<Categoria> Categorias = cat_context.Select(txtCategorySearch.Text);
            foreach (Categoria cat in Categorias)
                lstCategorias.Items.Add(cat);
            ActiveCategorySearch = true;
        }

        private void btnAgregarCategoria_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Categoria cat = new Categoria
            {
                Nombre = txtNewCategoryName.Text,
                Descripcion = string.Empty
            };
            cat_context.Insert(cat);
            lstCategorias.Items.Clear();
            lstCategorias.Items.Add("(Ver todos)");
            CargarCategorias();
        }

        private void btnEliminarCategoria_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            object selected = lstCategorias.SelectedItem;
            if (selected is Categoria)
            {
                Categoria cat_selected = selected as Categoria;
                cat_context.Delete(cat_selected);
                lstCategorias.Items.Clear();
                lstCategorias.Items.Add("(Ver todos)");
                CargarCategorias();
            }
            else
            {
                MessageBox.Show("No se puede eliminar el item seleccionado");
            }
        }

        private void lstCategorias_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lstCategorias.SelectedIndex == 0)
            {
                Refresh();
                ActiveCategorySearch = false;
            }
            else if (ActiveCategorySearch && lstCategorias.SelectedIndex == 1)
            {
                lstCategorias.Items.Clear();
                lstCategorias.Items.Add("(Ver todos)");
                CargarCategorias();
                txtCategorySearch.Text = string.Empty;
                ActiveCategorySearch = false;
            }
            else
            {
                Categoria cat = (lstCategorias.SelectedItem as Categoria);
                grdContainer.Children.Clear();
                SnippetList list = new SnippetList()
                {
                    Snippets = context.Select(cat)
                };
                list.Actualizar += new EventHandler<SnippetEventArgs>(btnActualizar_Click);
                list.Eliminar += new EventHandler<SnippetEventArgs>(btnEliminar_Click);
                list.Ver += new EventHandler<SnippetEventArgs>(btnVer_Click);
                grdContainer.Children.Add(list);
            }
        }

        private void btnVer_Click(object sender, SnippetEventArgs args)
        {
            Snippet result = args.Result;
            grdContainer.Children.Clear();
            SnippetView view = new SnippetView()
            {
                Snippet = result,
            };
            grdContainer.Children.Add(view);
        }
    }
}