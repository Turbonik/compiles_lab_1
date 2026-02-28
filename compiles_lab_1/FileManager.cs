namespace compiles_lab_1
{
    public class FileManager
    {
        public string OpenFileDialogAndRead(out string path)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;
                return File.ReadAllText(path);
            }

            path = null;
            return null;
        }

        public void SaveFile(string path, string text)
        {
            File.WriteAllText(path, text);
        }

        public string SaveFileDialogAndWrite(string text)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, text);
                return dialog.FileName;
            }

            return null;
        }
    }
}
