using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace pdfslownessrepro
{
	public class PDFViewerViewModel : INotifyPropertyChanged
    {
		public PDFViewerViewModel()
		{
            
		}

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged( [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null )
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if ( handler != null )
            {
                PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
            }
        }

        private Stream _pdfStream;
        public Stream PDFStream
        {
            get => _pdfStream;
            set
            {
                _pdfStream = value;
                OnPropertyChanged( nameof( PDFStream ) );
            }
        }

        public void Open(string file)
        {
            if ( PDFStream != null )
            {
                PDFStream.Close( );
                PDFStream.Dispose( );
                PDFStream = null;
            }

            PDFStream = typeof( PDFViewerViewModel ).GetTypeInfo( ).Assembly.GetManifestResourceStream( file );
        }
    }
}

