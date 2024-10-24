using System.Runtime.InteropServices;
using System.Text.Json;

namespace LanguageTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = GetDownloadsPath();
                openFileDialog.Filter = "txt files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    Dictionary<string, string> lang = new Dictionary<String, String>();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string jsonString = reader.ReadToEnd();
                        lang = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
                    }


                    int i = 1;

                    foreach (var pair in lang)
                    {
                        Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
                        ListViewItem item = new(i++.ToString());
                        item.SubItems.Add(pair.Key);
                        item.SubItems.Add(pair.Value);
                        listView.Items.Add(item);
                        if (listView.Items.Count > 0 && listView.SelectedItems.Count == 0) { listView.Items[listView.Items.Count - 1].EnsureVisible(); };
                    }
                }

                try
                {
                    listView.Select();
                    ListViewItem item = listView.SelectedItems[0];
                    keyLabel.Text = item.SubItems[1].Text;
                    currentLabel.Text = item.SubItems[2].Text;
                }
                catch { return; }
            }


        }

        public static string GetDownloadsPath()
        {
            string path = null;
            path = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            path = Path.Combine(path, "Downloads");
            return path;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView.SelectedItems[0];
                keyLabel.Text = item.SubItems[1].Text;
                currentLabel.Text = item.SubItems[2].Text;
            }
            catch { return; }
        }
    }
}