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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUIVinterEksamen20152016
{
    /// <summary>
    /// Interaction logic for ChooseFileDialog.xaml
    /// </summary>
    public partial class ChooseFileDialog : Window
    {
        class DialogData : INotifyPropertyChanged
        {
            string _filePath;
            public string FilePath
            {
                get { return _filePath; }
                set { _filePath = value; Notify("FilePath"); }
            }

            // INotifyPropertyChanged Members
            public event PropertyChangedEventHandler PropertyChanged;
            void Notify(string prop) { if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); } }
        }

        DialogData data = new DialogData();

        public string FilePath
        {
            get { return data.FilePath; }
            set { data.FilePath = value; }
        }

        public ChooseFileDialog()
        {
            InitializeComponent();

            DataContext = data;
        }

        private void ChooseBtn_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = FilePath;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               FilePath = dlg.FileName;
            }
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if(FilePathTbx.Text != "")
            Properties.Settings.Default.FilePath = FilePathTbx.Text;
            Close();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
