using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tharga.SizeExplorer.Client.ViewModels;

namespace Tharga.SizeExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SizeExplorerViewModel _sizeExplorerViewModel;

        public MainWindow()
        {
            //Tharga.Support.Toolkit.Support.ExceptionOccurredEvent += Support_ExceptionOccurredEvent;
            //Support.Toolkit.Support.Instance.StartSessionAsync();

            var loadTreeAsync = !DesignerProperties.GetIsInDesignMode(this);
            _sizeExplorerViewModel = new SizeExplorerViewModel(loadTreeAsync);

            InitializeComponent();

            DataContext = _sizeExplorerViewModel;
            //statusBar.DataContext = _sizeExplorerViewModel;
            //fileScanCountText.DataContext = _sizeExplorerViewModel;
        }

        //void Support_ExceptionOccurredEvent(object sender, Tharga.Support.Toolkit.Support.ExceptionOccurredEventArgs e)
        //{
        //    MessageBox.Show("WCF Exception", string.Format("WCF Command {0}. Message {1}", e.WcfCommand, e.Exception.Message));
        //}

        //TODO:
        /*
         * ! A map that has been opened is not sorted by size (as maps that have not been opened)
         * 
         * > Sort folders in order of size
         * > Show also folders in the file view
         * 
         * > Ask if a network drive is to be scanned
         * > Right click menu (Scan, Stop Scan)
         * 
         * 
         * > Find correct icons for special desktop icons
         * > Move icon lookup to a separate class
         * 
Setup:
Default Company Name -> Tharga
SizeExplorer.Setup -> SizeExplorer
Lägg till i program files mappen

Features:
Sortera mapparna efter storlek
Delete folder should update the GUI (Recursivly)


         * 
         * Listen to changes
         * = File size
         * > File name
         * = Last Write Time
         * 
         * = Creation of new files
         * = Deletion of files
         * > Movement of files
         * 
         * > Creation of folders
         * > Deletion of folders
         * > Movement of folders
         * > Name change of folders
         * 
         * ! In all cases, update the size of parent folders.
         * 
         * Visible
         * > Icons for files
         * > Icons for folders
         * > Show attributes (Visible, Archive, System and such)
         * 
         * Legend:
         * = Done
         * > To be developed
         */

        private void FolderTree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //FileList.ItemsSource = ((FolderViewModel)e.NewValue).Files;

            //((FolderViewModel)FileList.ItemsSource).
            //((FolderViewModel) e.NewValue).Hook(_sizeExplorerViewModel.Files);
            //FileList.SetBinding( )
            //if ( FileList.ItemsSource  == null )
            //    FileList.ItemsSource = new ObservableCollection<FileViewItemModel>();
            //((FolderViewModel)e.NewValue).HookFileList(ref );
        }
    }
}
