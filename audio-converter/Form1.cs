using System.Diagnostics;
using System.Xml;
using FFMpegCore;

namespace audio_converter
{
    public partial class Form1 : Form
    {
        private (string, Label, Label, ComboBox, Button)[] selectedFiles = [];
        private (int, int) fileListLocation = (0, 300);
        private int fileComponentHeight = 30;
        private string[] acceptableFileFormats = ["mp3", "wav"];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // TAKE DROPPED ITEMS
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);

            addNewFiles(fileNames);
            //displayFileNames();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void addNewFiles(string[] pathNames)
        {
            Random rnd = new Random();

            bool selectedFilesDoNotContain(string fileName)
            {
                return !selectedFiles.Any(file => file.Item1 == fileName);
            }

            pathNames = Array.FindAll(pathNames, file => acceptableFileFormats.Contains(file.Split("\\").Last().Split(".").Last()));
            pathNames = Array.FindAll(pathNames, selectedFilesDoNotContain);

            int i = selectedFiles.Length;
            foreach (string pathName in pathNames)
            {
                Label indexLabel = new();
                Label nameLabel = new();
                ComboBox comboBox = new();
                Button button = new();

                indexLabel.Width = 25;
                indexLabel.Text = (i + 1).ToString();
                indexLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);

                nameLabel.Text = pathName.Split("\\").Last();

                comboBox.Items.AddRange(acceptableFileFormats);
                comboBox.Width = 100;
                comboBox.SelectedIndex = 0;
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                button.Width = 30;
                button.Height = fileComponentHeight;
                button.Text = "x";
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Cursor = Cursors.Hand;
                button.Click += (s, e) =>
                {
                    selectedFiles = Array.FindAll(selectedFiles, file => file.Item1 != pathName);
                    fileComponentList.Controls.Remove(indexLabel);
                    fileComponentList.Controls.Remove(nameLabel);
                    fileComponentList.Controls.Remove(button);
                    fileComponentList.Controls.Remove(comboBox);
                    rerenderFileComponents(selectedFiles);
                };

                selectedFiles = selectedFiles.Append((
                    pathName,
                    indexLabel,
                    nameLabel,
                    comboBox,
                    button
                )).ToArray();
                i++;
            }

            rerenderFileComponents(selectedFiles);
        }

        private void rerenderFileComponents((string, Label, Label, ComboBox, Button)[] files)
        {
            fileComponentList.Controls.Clear();

            int i = 0;
            foreach (var file in files)
            {
                // INDEX LABEL
                file.Item2.Text = (i + 1).ToString();

                fileComponentList.Controls.Add(file.Item2, 0, i);
                fileComponentList.Controls.Add(file.Item3, 1, i);
                fileComponentList.Controls.Add(file.Item4, 2, i);
                fileComponentList.Controls.Add(file.Item5, 3, i);

                i++;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            convertButton.Enabled = false;

            foreach (var file in selectedFiles)
            {
                string newFormat = file.Item4.SelectedItem.ToString();
                string newPath = String.Join(".", file.Item1.Split(".")[..^1]) + "." + newFormat;

                if (file.Item1 != newPath)
                {
                    FFMpegArguments.FromFileInput(file.Item1).OutputToFile(newPath).ProcessSynchronously();
                }
            }

            convertButton.Enabled = true;
        }
    }
}
