using System;
using System.Windows.Forms;
using UnifiedCSPROJOutputPath.Views;

namespace UnifiedCSPROJOutputPathTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(
                new TestUnifiedCSPROJOutputPathForm()
            );
        }
    }
}
