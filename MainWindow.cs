using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dotNetdotMatrix
{

    public partial class MainWindow : Form
    {
        Charset set;
        Brush dotOff = new SolidBrush(ColorTranslator.FromHtml("#111"));
        Brush dotOn = new SolidBrush(ColorTranslator.FromHtml("#E8AA0E")); //#AAE3FF

        List<Token> tokens = new List<Token>();
        int highestTokenIndex = 0;
        int tokenIndex = 0;
        int tokenDuration = 0;
        int tokenTimeElapsed = 0;

        List<Point> renderedPixels = new List<Point>();
        Random rndm = new Random(int.Parse(DateTime.Now.ToLongTimeString().Replace(":", "")));

        int vIndex = 0;
        int vIndex_;
        int hIndex = 0;
        int hIndex_;

        int charWidth = 5;
        int dotSize = 5;

        public MainWindow() {
            InitializeComponent();
            pnlDisplay.Paint += pnlDisplay_Paint;
            btnClearToken.Click += btnClearToken_Click;
            btnRemoveToken.Click += btnRemoveToken_Click;
            btnAddToken.Click += btnAddToken_Click;
            btnSelectCharset.Click += btnSelectCharset_Click;
            btnClearComplete.Click += btnClearComplete_Click;
            nudLines.ValueChanged += nudLines_ValueChanged;
            Resize += nudLines_ValueChanged;
            lvwTokens.SelectedIndexChanged += lvwTokens_SelectedIndexChanged;
            tmrClock.Tick += tmrClock_Tick;
            btnStartAnimation.Click += btnStartAnimation_Click;
            btnStopAnimation.Click += btnStopAnimation_Click;
            btnRestartAnimation.Click += btnRestartAnimation_Click;
            pnlMargin.Padding = new Padding(15, (pnlMargin.Height - 40) / 2, 15, (pnlMargin.Height - 40) / 2);
        }

        private void btnClearComplete_Click(object sender, EventArgs e) {
            pnlDisplay.CreateGraphics().FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, pnlDisplay.Width, pnlDisplay.Height));
            for (int i = 0; i < pnlDisplay.Width / dotSize; i++) {
                for (int j = 0; j < pnlDisplay.Height / dotSize; j++) {
                    Rectangle rect = new Rectangle(dotSize * i, dotSize * j, dotSize, dotSize);
                    pnlDisplay.CreateGraphics().FillEllipse(dotOff, rect);
                }
            }
        }

        private void btnRestartAnimation_Click(object sender, EventArgs e) {
            tokenIndex = 0;
            tokenTimeElapsed = 0;
            bool indexExists = false;
            foreach (Token t in tokens) {
                if (t.Index == 0) {
                    tokenDuration = t.Duration;
                    indexExists = true;
                }
            }
            if (!indexExists && tokens.Count > 0) {
                tokenDuration = tokens[0].Duration;
            } else {
                tokenDuration = 0;
            }
            tmrClock.Start();
        }

        private void btnStopAnimation_Click(object sender, EventArgs e) {
            tmrClock.Stop();
            btnStartAnimation.Enabled = true;
            btnStopAnimation.Enabled = false;
        }

        private void btnStartAnimation_Click(object sender, EventArgs e) {
            tmrClock.Start();
            btnStartAnimation.Enabled = false;
            btnStopAnimation.Enabled = true;
        }

        private void lvwTokens_SelectedIndexChanged(object sender, EventArgs e) {
            btnRemoveToken.Enabled = lvwTokens.SelectedItems.Count > 0;
        }

        private void nudLines_ValueChanged(object sender, EventArgs e) {
            if (set != null) {
                pnlMargin.Padding = new Padding(15, (pnlMargin.Height - set.LineHeight * dotSize * (int) nudLines.Value) / 2, 15, (pnlMargin.Height - set.LineHeight * dotSize * (int) nudLines.Value) / 2);
            } else {
                pnlMargin.Padding = new Padding(15, (pnlMargin.Height - 40) / 2, 15, (pnlMargin.Height - 40) / 2);
            }
        }

        private void btnRemoveToken_Click(object sender, EventArgs e) {
            for (int i = 0; i < lvwTokens.SelectedIndices.Count; i++) {
                tokens.RemoveAt(i);
                lvwTokens.Items.RemoveAt(i);
            }
            tmrClock.Stop();
            tokenTimeElapsed = 0;
            tokenIndex = 0;
            tokenDuration = 0;
            foreach (Token t in tokens) {
                if (t.Index > highestTokenIndex)
                    highestTokenIndex = t.Index;
            }
            tmrClock.Start();
        }

        private void tmrClock_Tick(object sender, EventArgs e) {
            if (tokenTimeElapsed >= tokenDuration) {
                tokenTimeElapsed = 0;
                tokenDuration = 0;
                ClearDisplay(pnlDisplay.CreateGraphics());
                foreach (Token t in tokens) {
                    if (t.Index == tokenIndex || (t.Keep && (tokenIndex - 1 == t.Index))) {
                        dotOn = new SolidBrush(ColorTranslator.FromHtml(tbxColor.Text));
                        RenderToken(t);
                        if (t.Duration > tokenDuration)
                            tokenDuration = t.Duration;
                    }
                }
                tokenIndex++;
                if (tokenIndex > highestTokenIndex)
                    tokenIndex = 0;
            }
            if (tokens.Count > 0)
                tokenTimeElapsed++;
        }

        private void btnAddToken_Click(object sender, EventArgs e) {
            using (AddTokenDialog atd = new AddTokenDialog(set)) {
                if (atd.ShowDialog() == DialogResult.OK) {
                    tokens.Add(atd.token);
                    lvwTokens.Items.Add(new ListViewItem(new string[] { atd.token.Content, atd.token.Orientation.ToString(), atd.token.Index.ToString() + "/" + atd.token.Line.ToString(), atd.token.Duration.ToString() + " sec.", atd.token.Inverted.ToString(), atd.token.Keep.ToString() }));
                    if (atd.token.Index > highestTokenIndex)
                        highestTokenIndex = atd.token.Index;
                    tmrClock.Start();
                }
            }
        }

        private void btnSelectCharset_Click(object sender, EventArgs e) {
            using (SelectCharsetDialog scd = new SelectCharsetDialog()) {
                if (scd.ShowDialog() == DialogResult.OK) {
                    set = scd.Set;
                    btnAddToken.Enabled = btnClearToken.Enabled = tbxColor.Enabled = nudLines.Enabled = lvwTokens.Enabled = btnStopAnimation.Enabled = btnRestartAnimation.Enabled = btnClearComplete.Enabled = true;
                    pnlMargin.Padding = new Padding(15, (pnlMargin.Height - set.LineHeight * dotSize * (int) nudLines.Value) / 2, 15, (pnlMargin.Height - set.LineHeight * dotSize * (int) nudLines.Value) / 2);
                }
            }
        }

        public void pnlDisplay_Paint(object sender, PaintEventArgs e) {
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, pnlDisplay.Width, pnlDisplay.Height));
            for (int i = 0; i < pnlDisplay.Width / dotSize; i++) {
                for (int j = 0; j < pnlDisplay.Height / dotSize; j++) {
                    Rectangle rect = new Rectangle(dotSize * i, dotSize * j, dotSize, dotSize);
                    e.Graphics.FillEllipse(dotOff, rect);
                }
            }
        }

        public void ClearDisplay(Graphics g, bool clearTokens = false) {
            vIndex = 0;
            hIndex = 0;
            if (clearTokens) {
                tokens.Clear();
                highestTokenIndex = 0;
                tokenIndex = 0;
                tmrClock.Stop();
                lvwTokens.Items.Clear();
            }

            foreach (Point pnt in renderedPixels) {
                Rectangle rect = new Rectangle(pnt, new Size(dotSize - 1, dotSize - 1));
                g.FillRectangle(dotOff, rect);
            }
            renderedPixels.Clear();
        }

        public void btnClearToken_Click(object sender, EventArgs e) {
            ClearDisplay(pnlDisplay.CreateGraphics(), true);
            dotOn = new SolidBrush(ColorTranslator.FromHtml(tbxColor.Text));
        }

        public void RenderToken(Token token) {
            dotOn = new SolidBrush(ColorTranslator.FromHtml(tbxColor.Text));
            if (!string.IsNullOrEmpty(token.Color))
                dotOn = new SolidBrush(ColorTranslator.FromHtml(token.Color));
            Graphics g = pnlDisplay.CreateGraphics();
            vIndex_ = vIndex;
            if (token.Orientation == Align.Left) {
                vIndex = 0;
            } else if (token.Orientation == Align.Middle) {
                vIndex = (pnlDisplay.Width / dotSize - set.MeasureString(token.Content)) / 2;
            } else if (token.Orientation == Align.Right) {
                vIndex = pnlDisplay.Width / dotSize - set.MeasureString(token.Content) + 1;
            } else if (token.Orientation == Align.FlowMiddle) {
                vIndex += ((pnlDisplay.Width - vIndex * dotSize) / dotSize - set.MeasureString(token.Content)) / 2;
            }
            if (token.Inverted) {
                for (int i = -1; i < set.MeasureString(token.Content); i++) {
                    for (int j = 0; j < set.LineHeight; j++) {
                        Rectangle rect = new Rectangle((i + vIndex) * dotSize, j * dotSize, dotSize, dotSize);
                        g.FillEllipse(dotOn, rect);
                    }
                }
            }
            foreach (char c in token.Content) {
                DisplayChar dc = set.GetCharacter(c);
                if (dc.CharHeight == 0) {
                    hIndex = hIndex_;
                    charWidth = dc.Definition.Length / set.CharHeight;
                } else {
                    hIndex_ = hIndex;
                    hIndex--;
                    charWidth = dc.Definition.Length / dc.CharHeight;
                }
                string[] def = SplitInParts(dc.Definition, charWidth).ToArray();
                for (int i = 0; i < def.Count(); i++) {
                    string s = def[i];
                    for (int j = 0; j < s.Count(); j++) {
                        char p = s[j];
                        if (p == '1') {
                            if (token.Inverted) {
                                Rectangle rect = new Rectangle((j + vIndex) * dotSize, (token.Line * set.LineHeight * dotSize) + ((i + dc.Baseline + hIndex) * dotSize), dotSize, dotSize);
                                g.FillEllipse(dotOff, rect);
                            } else {
                                Rectangle rect = new Rectangle((j + vIndex) * dotSize, (token.Line * set.LineHeight * dotSize) + ((i + dc.Baseline + hIndex) * dotSize), dotSize, dotSize);
                                g.FillEllipse(dotOn, rect);
                            }
                            Point pnt = new Point((j + vIndex) * dotSize, (token.Line * set.LineHeight * dotSize) + ((i + dc.Baseline + hIndex) * dotSize));
                            pnt.Offset(1, 1);
                            renderedPixels.Add(pnt);
                        }
                    }
                }
                vIndex += charWidth + 1;
                if (token.Orientation == Align.Flow || token.Orientation == Align.Left)
                    vIndex_ += charWidth + 1;
            }
            vIndex = vIndex_;
        }

        public static IEnumerable<string> SplitInParts(string s, int partLength) {
            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

    }
}
