using System;
using System.Windows.Controls;

namespace Snippet2
{
	/// <summary>
	/// Lógica de interacción para SnippetEdit.xaml
	/// </summary>
	public partial class SnippetEdit : UserControl
	{
		private EditingWay _way = EditingWay.CREATING;

		public event EventHandler<SnippetEventArgs> Confirmed;

		public SnippetEdit()
		{
			this.InitializeComponent();
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
			}
		}

		public EditingWay Way
		{
			private get { return _way; }
			set 
			{ 
				_way = value;
				btnCommand.Content = (_way == EditingWay.CREATING) ? "Create" : "Update" ;
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
			Confirmed(this, args);
		}
	}

	public class SnippetEventArgs : EventArgs
	{
		public Snippet Result { get; set; }
	}
}