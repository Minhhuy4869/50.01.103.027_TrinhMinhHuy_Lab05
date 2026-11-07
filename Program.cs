using _5001103027_TrinhMinhHuy_Lab05;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _5001103027_TrinhMinhHuy_Lab05
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}