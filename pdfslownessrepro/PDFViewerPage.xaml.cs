using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pdfslownessrepro
{	
	public partial class PDFViewerPage : ContentPage
	{
		private PDFViewerViewModel _viewModel;

		public PDFViewerPage ()
		{
			InitializeComponent ();

			BindingContext = _viewModel = new PDFViewerViewModel( );
		}

		public void Open( string file ) {
			_viewModel.Open( file );
		}
	}
}

