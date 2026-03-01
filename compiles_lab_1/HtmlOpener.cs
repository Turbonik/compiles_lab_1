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
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            string HelpFile = lang == "ru"
                ? "HTMLs/help_ru.html"
                : "HTMLs/help_en.html";

            string helpPath = Path.Combine(basePath, HelpFile);


            CheckPath(helpPath);
        }

        public static void About()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            string AboutFile = lang == "ru"
             ? "HTMLs/about_ru.html"
             : "HTMLs/about_en.html";

            string aboutPath = Path.Combine(basePath, AboutFile);

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
