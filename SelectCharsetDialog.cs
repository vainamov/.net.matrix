using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace dotNetdotMatrix
{
    public partial class SelectCharsetDialog : Form
    {
        public Charset Set { get; set; }

        public SelectCharsetDialog()
        {
            InitializeComponent();
            btnSelect.Click += BtnSelect_Click;
            btnApply.Click += BtnApply_Click;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Charsets (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Set = JsonConvert.DeserializeObject<Charset>(System.IO.File.ReadAllText(ofd.FileName));
                        lblName.Text = Set.Name;
                        lblAuthor.Text = Set.Author;
                        tbxIncludedChars.Text = string.Join(" / ", Set.GetAllCharacters());
                        btnApply.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("The selected file is not a valid charset.", "Invalid Charset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnApply.Enabled = false;
                    }
                }
            }
        }
    }
}
