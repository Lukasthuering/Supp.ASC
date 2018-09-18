using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System.IO;
using System.Windows.Forms;

namespace Supp.ASC.ViewModel
{
    public class MainViewModel : BasicViewModel
    {
        #region Memebers

        private string _filepath;
        private bool _IsChecked;

        #endregion

        public string TextBoxPath
        {
            get { return _filepath; }
            set
            {
                _filepath = value;
                RaisePropertyChanged("TextBoxPath");
            }
        }

        public bool ExcelIsSelected
        {
            get { return _IsChecked; }
            set
            {
                _IsChecked = value;
                RaisePropertyChanged("ExcelIsSelected");
            }
        }

        public RelayCommands SelectCommand { get; set; }

        public MainViewModel()
        {
            SelectCommand = new RelayCommands(onSelectClick);
        }

        public void onSelectClick()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = @"C:\";
            dlg.Title = "Excel Dateien suchen";
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Excel Datei 13(*.xlsx)|*.xlsx|Excel Datei 10 (*.xls)|*.xls";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;
            dlg.ReadOnlyChecked = true;
            dlg.ShowReadOnly = true;
            TextBoxPath = dlg.FileName;
        }
    }
}