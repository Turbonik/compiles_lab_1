namespace compiles_lab_1
{
    public class FileManager
    {
        public string CurrentFilePath { get; private set; }

        public string OpenFile()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = dialog.FileName;
                return File.ReadAllText(CurrentFilePath);
            }

            return null;
        }

        public void SaveFile(string text)
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                SaveFileAs(text);
                return;
            }

            File.WriteAllText(CurrentFilePath, text);
        }

        public void SaveFileAs(string text)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = dialog.FileName;
                File.WriteAllText(CurrentFilePath, text);
            }
        }

        public void CreateNew()
        {
            CurrentFilePath = null;
        }
    }
}
