using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pdfslownessrepro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            OpenPDFViewer( "pdfslownessrepro.Documents.ASAP EVAP ROOF_Contract Roofing & Storm.pdf" );
        }

        void Button2_Clicked( System.Object sender, System.EventArgs e )
        {
            OpenPDFViewer( "pdfslownessrepro.Documents.Weekly Disposables Sheets 8_Weekly Disposables Sheet EDS.pdf" );
        }

        bool _openPdfViewer;
        private void OpenPDFViewer(string file )
        {
            if ( _openPdfViewer ) return;

            _openPdfViewer = true;
            var pg = new PDFViewerPage( );
            pg.Open( file );
            this.Navigation.PushAsync( pg );
            _openPdfViewer = false;
        }
    }
}

