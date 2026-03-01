using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiles_lab_1
{
    internal static class HtmlOpener
    {
        readonly static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        public static void Help()
        {
 
            string helpPath = Path.Combine(basePath, "HTMLs", "help.html");


            CheckPath(helpPath);
        }

        public static void About()
        {
 
            string aboutPath = Path.Combine(basePath, "HTMLs", "about.html");

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
