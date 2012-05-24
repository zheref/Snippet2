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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Snippet2.Model;

namespace Snippet2
{
	/// <summary>
	/// Lógica de interacción para SnippetList.xaml
	/// </summary>
	public partial class SnippetList : UserControl
	{
        List<Snippet> _snippets = new List<Snippet>();

        public List<Snippet> Snippets
        {
            get { return _snippets; }
            set 
            {
                _snippets = value;
                Refresh();
            }
        }

        private void Refresh()
        {
            lstSnippets.Items.Clear();
            foreach (Snippet sni in _snippets)
                lstSnippets.Items.Add(sni);
        }

        public void AddSnippet(Snippet sni)
        {
            _snippets.Add(sni);
            Refresh();
        }

        public event EventHandler<SnippetEventArgs> Actualizar;
        public event EventHandler<SnippetEventArgs> Eliminar;

		public SnippetList()
		{
			this.InitializeComponent();
		}

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Snippet selected = lstSnippets.SelectedItem as Snippet;
            SnippetEventArgs args = new SnippetEventArgs
            {
                Result = selected
            };
            Eliminar(this, args);
            Refresh();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Snippet selected = lstSnippets.SelectedItem as Snippet;
            SnippetEventArgs args = new SnippetEventArgs
            {
                Result = selected
            };
            Actualizar(this, args);
            Refresh();
        }
	}
}