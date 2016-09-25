using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace dotNetdotMatrix
{
    public partial class ExImportDialog : Form
    {
        public IEnumerable<Token> Tokens;

        public ExImportDialog() {
            InitializeComponent();
            btnExport.Click += btnExport_Click;
            btnImport.Click += btnImport_Click;
        }

        private void btnImport_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Tokens (*.json)|*.json";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    try {
                        Tokens = JsonConvert.DeserializeObject<IEnumerable<Token>>(System.IO.File.ReadAllText(ofd.FileName));
                        MessageBox.Show("Import successful.", ".net.matrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.Yes;
                    } catch {
                        MessageBox.Show("This is not a valid token file.", ".net.matrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e) {
            using (SaveFileDialog sfd = new SaveFileDialog()) {
                sfd.Filter = "Tokens (*.json)|*.json";
                if (sfd.ShowDialog() == DialogResult.OK) {
                    System.IO.File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(Tokens, Formatting.Indented));
                    MessageBox.Show("Export successful.", ".net.matrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.No;
                }
            }
        }
    }
}
