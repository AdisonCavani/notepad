using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        private FontDialog fontDialog;
        string path;
        public Notepad()
        {
            InitializeComponent();
            this.Text = "Untitled - Notepad";
        }

        public int newZoom;
        public float charNumber;
        public int linesNumber;
        public string title;
        public string strMyOriginalText;

        private async void notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox.Text != strMyOriginalText)
            {
                const string message = "Do you want to save changes?";
                const string caption = "Notepad";
                var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNoCancel,
                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(path))
                    {
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents (*.txt)|*.txt", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    path = sfd.FileName;
                                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                                    {
                                        await sw.WriteLineAsync(textBox.Text);
                                        this.Text = string.Format("{0} - Notepad", Path.GetFileName(sfd.FileName));
                                        Application.Exit();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(path))
                            {
                                await sw.WriteLineAsync(textBox.Text);
                                Application.Exit();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            strMyOriginalText = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            textBox.Clear();
            this.Text = "Untitled - Notepad";
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Notepad().Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents (*.txt)|*.txt", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            path = ofd.FileName;
                            Task<string> text = sr.ReadToEndAsync();
                            textBox.Text = text.Result;
                            strMyOriginalText = text.Result;
                            this.Text = string.Format("{0} - Notepad", Path.GetFileName(ofd.FileName));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents (*.txt)|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = sfd.FileName;
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(textBox.Text);
                                this.Text = string.Format("{0} - Notepad", Path.GetFileName(sfd.FileName));
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        await sw.WriteLineAsync(textBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents (*.txt)|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(textBox.Text);
                            this.Text = string.Format("{0} - Notepad", Path.GetFileName(sfd.FileName));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.CanUndo == true)
            {
                textBox.Undo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = string.Empty;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string date;
            date = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            //textBox.Text = textBox.Paste(date);
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                textBox.WordWrap = true;
                textBox.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                textBox.WordWrap = false;
                textBox.ScrollBars = ScrollBars.Both;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBox.Font = fontDialog.Font;
                    float oldFontSize;
                    oldFontSize = textBox.Font.Size;
                }
            }
            catch
            {

            }
            finally
            {
                zoomLbl.Text = "100%";
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {

            char[] removePercent = { '%' };
            string zoom = zoomLbl.Text.TrimEnd(removePercent);
            newZoom = Int32.Parse(zoom);

            if (newZoom != 500)
            {
                float currentSize;
                currentSize = textBox.Font.Size;
                currentSize += 1.0F;
                textBox.Font = new Font(textBox.Font.Name, currentSize,
                textBox.Font.Style, textBox.Font.Unit);

                if (true)
                {
                    newZoom += 10;
                    zoomLbl.Text = newZoom.ToString() + "%";
                }
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            char[] removePercent = { '%' };
            string zoom = zoomLbl.Text.TrimEnd(removePercent);
            newZoom = Int32.Parse(zoom);

            if (newZoom != 10)
            {
                float currentSize;
                currentSize = textBox.Font.Size;
                currentSize -= 1.0F;
                textBox.Font = new Font(textBox.Font.Name, currentSize,
                textBox.Font.Style, textBox.Font.Unit);

                if (true)
                {
                    newZoom -= 10;
                    zoomLbl.Text = newZoom.ToString() + "%";
                }
            }
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = 12.0F;
            textBox.Font = new Font(textBox.Font.Name, currentSize,
            textBox.Font.Style, textBox.Font.Unit);
            zoomLbl.Text = "100%";
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked == true)
            {
                statusBar.Visible = true;
            }
            else
            {
                statusBar.Visible = false;
            }
        }

        private void viewHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=uzyskiwanie+pomocy+dotyczącej+notatnika+w%C2%A0systemie+windows+10&go=Wyszukaj&qs=ds&form=QBRE");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com");
        }

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\winver.exe");
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //menuBar.BackColor = Color.White;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            charNumber = textBox.Text.Length;
            linesNumber = textBox.Lines.Length;
            title = this.Text;

            if (title.Contains("Untitled - Notepad"))
            {
                if (charNumber == 0)
                {
                    this.Text = "Untitled - Notepad";
                }
                else if (charNumber > 0)
                {
                    this.Text = "*Untitled - Notepad";
                }
            }
            countLbl.Text = string.Format("Ln {0}, Col {1}", linesNumber, charNumber);
        }
    }
}
