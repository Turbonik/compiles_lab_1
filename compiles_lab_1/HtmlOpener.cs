using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiles_lab_1
{
    internal static class HtmlOpener
    {
        public static void Help()
        {
            string exePath = Application.StartupPath;
            string helpPath = Path.Combine(exePath, "HTMLs", "help.html");

            CheckPath(helpPath);
        }

        public static void About()
        {
            string exePath = Application.StartupPath;
            string aboutPath = Path.Combine(exePath, "HTMLs", "about.html");
            
            CheckPath(aboutPath);
        }

        public static void CheckPath(string Path)
        {

            if (File.Exists(Path))
                System.Diagnostics.Process.Start
                    (new System.Diagnostics.ProcessStartInfo(Path) { UseShellExecute = true });
            else
                MessageBox.Show("Файл не найден:\n" + Path);
        }

    }
}
