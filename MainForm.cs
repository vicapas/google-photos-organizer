using GooglePhotosOrganizer.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace GooglePhotosOrganizer
{
    public partial class MainForm : Form
    {
        private string newLine = "\r\n";
        private List<CopyFile> copyFiles = new List<CopyFile>();
        private List<string> files = new List<string>();
        private List<string> jsonFiles = new List<string>();
        private List<string> formats = new List<string>();
        private string[] checkedFormats = [".jpg", ".mp4", ".m4v", ".mov", ".jpeg", ".3gp", ".gif", ".png"];
        private string[] videoFormats = [".mp4", ".m4v", ".mov", ".3gp", ".avi", ".mpeg", ".wmv", ".flv", ".mkv", ".divx", ".xvid", ".rm"];

        public MainForm()
        {
            InitializeComponent();
            videoSeparateCombo.SelectedIndex = 0;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    selectedPath.Text = dialog.SelectedPath;
                    Analize(dialog.SelectedPath);
                    jsonFiles = files.Where(f => Path.GetExtension(f).ToLower().Equals(".json")).ToList();
                    fileCounter.Text = files.Count.ToString();
                    UpdateFormatList();
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    copyPath.Text = Path.Combine(dialog.SelectedPath, "Fotos organizadas");
                    copyCounter.Text = files.Count(f => formatList.Items.Contains(Path.GetExtension(f))).ToString();
                }
            }
        }

        private void organizeButton_Click(object sender, EventArgs e)
        {
            progressActionLabel.Text = $"Analizando ficheros";
            progressActionLabel.Invalidate();
            progressActionLabel.Update();
            progressActionLabel.Refresh();
            AddMetadata();
            progressActionLabel.Text = $"Creando directorios";
            progressActionLabel.Invalidate();
            progressActionLabel.Update();
            progressActionLabel.Refresh();
            CreatingDirectories();
            progressActionLabel.Text = $"Copiando ficheros";
            progressActionLabel.Invalidate();
            progressActionLabel.Update();
            progressActionLabel.Refresh();
            CopyingDirectories();
            progressActionLabel.Text = $"Hecho!";
            progressActionLabel.Invalidate();
            progressActionLabel.Update();
            progressActionLabel.Refresh();
        }

        private void formatList_SelectedValueChanged(object sender, EventArgs e)
        {
            copyCounter.Text = files.Count(f => formatList.Items.Contains(Path.GetExtension(f))).ToString();
        }

        private void UpdateFormatList()
        {
            var ordered = formats.Order();
            foreach (var format in ordered)
            {
                formatList.Items.Add(format, checkedFormats.Contains(format.ToLower()));
            }
        }

        private void Analize(string path)
        {
            var directoryFiles = Directory.GetFiles(path);

            foreach (var file in directoryFiles)
            {
                AnalizeFile(file);
            }

            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                Analize(directory);
            }
        }

        private void AnalizeFile(string path)
        {
            files.Add(path);
            var extension = Path.GetExtension(path);
            if (!formats.Contains(extension) && !extension.ToLower().Equals(".json")) formats.Add(extension);
        }

        private void AddMetadata()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = files.Count;

            foreach (var file in files)
            {
                progressBar.Value++;
                var isValid = formatList.CheckedItems.Contains(Path.GetExtension(file));
                if (isValid)
                {
                    var fileName = Path.GetFileName(file);
                    var json = jsonFiles.FirstOrDefault(j => Path.GetFileNameWithoutExtension(j).Equals(fileName));
                    DateTime? dateTime = null;

                    if (json != null)
                    {
                        var contentJson = File.ReadAllText(json);
                        var metadata = JsonConvert.DeserializeObject<MetadataModel>(contentJson);
                        dateTime = GetDateTime(metadata);
                    }

                    copyFiles.Add(new CopyFile(file, fileName, dateTime));
                }
            }
        }

        private DateTime GetDateTime(MetadataModel metadata)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            if (metadata.photoTakenTime.timestamp != null)
            {
                dateTime = dateTime.AddSeconds((long)metadata.photoTakenTime.timestamp).ToLocalTime();
            }

            return dateTime;
        }

        private void CreatingDirectories()
        {
            progressBar.Value = 0;

            var existsCopyFolder = Directory.Exists(copyPath.Text);
            if (!existsCopyFolder) Directory.CreateDirectory(copyPath.Text);

            var years = copyFiles.Select(c => c.Year).Distinct().ToList();
            foreach (var year in years)
            {
                var yearFolder = year != null ? year.ToString() : "Sin fecha";
                var yearFolderPath = Path.Combine(copyPath.Text, yearFolder);
                var existsYearFolder = Directory.Exists(yearFolderPath);
                if (!existsYearFolder) Directory.CreateDirectory(yearFolderPath);
            }
        }

        private void CopyingDirectories()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = copyFiles.Count;

            foreach (var file in copyFiles)
            {
                var yearFolder = file.Year != null ? file.Year.ToString() : "Sin fecha";
                var pathToCopy = Path.Combine(copyPath.Text, yearFolder);

                if (videoSeparateCombo.SelectedItem.Equals("SI") && videoFormats.Contains(Path.GetExtension(file.Path).ToLower()))
                {
                    pathToCopy = Path.Combine(pathToCopy, "Videos");
                    if (!Directory.Exists(pathToCopy)) Directory.CreateDirectory(pathToCopy);
                }

                var dateTime = file.DateTime != null ? ((DateTime)file.DateTime).ToString("yyyyMMdd") : string.Empty;
                if (!file.FileName.Contains(dateTime)) file.FileName = $"{dateTime}_{file.FileName}";

                var pathToCopyWithFileName = Path.Combine(pathToCopy, file.FileName);
                var exists = File.Exists(pathToCopyWithFileName);
                if (!exists)File.Copy(file.Path, pathToCopyWithFileName);

                progressBar.Value++;
            }
        }
    }
}
