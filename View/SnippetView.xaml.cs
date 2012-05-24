using System;
using System.Windows.Controls;

using Snippet2.Model;
using Snippet2.DAL;
using System.Collections.Generic;

namespace Snippet2
{
	/// <summary>
	/// Lógica de interacción para SnippetEdit.xaml
	/// </summary>
	public partial class SnippetView : UserControl
	{
		public event EventHandler<SnippetEventArgs> CategoryAdding;

		public SnippetView()
		{
			this.InitializeComponent();
            DBCategoriaDataContext catContext = new DBCategoriaDataContext();
            List<Categoria> categorias = catContext.SelectAll();
            foreach (Categoria cat in categorias)
                lstCategories.Items.Add(cat);
		}

        void RefreshCategorias()
        {
            DBCategoriaDataContext catContext = new DBCategoriaDataContext();
            List<Categoria> categoriasSni = catContext.Select(Snippet);
            foreach (Categoria cat in categoriasSni)
                lstCategoriesSni.Items.Add(cat);
        }

		Snippet _snippet = null;

		public Snippet Snippet
		{
			private get
			{
				if (_snippet == null)
					_snippet = new Snippet();
				return _snippet;
			}
			set
			{
				_snippet = value;
				txtName.Text = _snippet.Nombre;
				txtDescription.Text = _snippet.Descripcion;
                RefreshCategorias();
			}
		}


		private void btnCommand_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			SnippetEventArgs args = new SnippetEventArgs
			{
				Result = new Snippet
				{
					ID = Snippet.ID,
					Nombre = txtName.Text,
					Descripcion = txtDescription.Text
				}
			};
			CategoryAdding(this, args);
		}

		private void btnApply_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            DBSnippetContext catContext = new DBSnippetContext();
            catContext.Insert(Snippet, lstCategories.SelectedItem as Categoria);
            RefreshCategorias();
		}
	}
}