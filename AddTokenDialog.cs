using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dotNetdotMatrix {

    public partial class AddTokenDialog : Form {
        public Token token { get; set; }

        Charset set;

        public AddTokenDialog(Charset set) {
            InitializeComponent();
            btnAdd.Click += BtnApply_Click;
            Shown += addTokenDialog_Shown;
            this.set = set;
        }

        private void addTokenDialog_Shown(object sender, EventArgs e) {
            cbxAlign.SelectedIndex = 0;
        }

        private void BtnApply_Click(object sender, EventArgs e) {
            if (invalidCharactersInToken(tbxContent.Text).Count() == 0) {
                token = new Token(tbxContent.Text, chxInvert.Checked, (Align) cbxAlign.SelectedIndex, false, (int) nudDuration.Value, (int) nudIndex.Value, (int) nudLine.Value, chxKeep.Checked, tbxColor.Text);
                DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show("You cannot use characters that aren't defined in the charset.", "Invalid Characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<Char> invalidCharactersInToken(string s) {
            foreach (char c in s) {
                if (!set.GetAllCharacters().Contains(c.ToString())) {
                    yield return c;
                }
            }
        }
    }
}
