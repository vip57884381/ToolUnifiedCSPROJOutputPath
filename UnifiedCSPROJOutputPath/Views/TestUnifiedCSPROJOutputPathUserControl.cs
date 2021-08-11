using LibraryBasic.Models;
using System;
using System.Windows.Forms;

namespace UnifiedCSPROJOutputPath.Views
{
    public partial class TestUnifiedCSPROJOutputPathUserControl : UserControl
    {
        public TestUnifiedCSPROJOutputPathUserControl()
        {
            InitializeComponent();
        }

        private void Search_Folder_Button_1_Click(object sender, EventArgs e)
        {
            string path = MicrosoftWin32Custom.folderBrowserDialog();

            if(path != "")
            {
                Search_Folder_TextBox_1.Text = path
                    + "/";
            }
        }

        private void DES_Folder_Button_1_Click(object sender, EventArgs e)
        {
            string path = MicrosoftWin32Custom.folderBrowserDialog();
            
            if (path != "")
            {
                DES_Folder_TextBox_1.Text = path
                    + "/";
            }
        }

        private void Execute_Button_1_Click(object sender, EventArgs e)
        {
            string search_Folder 
                = Search_Folder_TextBox_1.Text;
            string DES_Folder
                = DES_Folder_TextBox_1.Text;
            string ouputFolder
                = OuputFolder_TextBox_1.Text;

            MessageWin.show(
                (
                    UnifiedCSPROJOutputPath
                        .Models
                        .UnifiedCSPROJOutputPath
                        .updateCSPROJOutputPath(
                            DES_Folder
                            , ouputFolder
                            , search_Folder
                        )
                        ? "Success"
                        : "Fail"
                )
            );
        }

        private void DelBak_Button_1_Click(object sender, EventArgs e)
        {
            string search_Folder
                = Search_Folder_TextBox_1.Text;

            MessageWin.show(
                (
                    UnifiedCSPROJOutputPath
                        .Models
                        .UnifiedCSPROJOutputPath
                        .delCSPROJBak(
                            search_Folder
                        )
                        ? "Success"
                        : "Fail"
                )
            );
        }

        private void BakToCSPROJ_Button_1_Click(object sender, EventArgs e)
        {
            string search_Folder
                = Search_Folder_TextBox_1.Text;

            MessageWin.show(
                (
                    UnifiedCSPROJOutputPath
                        .Models
                        .UnifiedCSPROJOutputPath
                        .restoreBakToCSPROJ(
                            search_Folder
                        )
                        ? "Success"
                        : "Fail"
                )
            );
        }
    }
}
