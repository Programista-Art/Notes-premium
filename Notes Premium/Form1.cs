
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Notes_Premium
{
    public partial class Form1 : Form
    {
        private
            string _openFile;

        public Form1()
        {
            InitializeComponent();
            OPD.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            SD.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

        }
        public bool ch = true;
        public object Sytem { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string getJustFileName(string fullFilePath)
        {
            string[] filenamePaths = fullFilePath.Split('\\');
            return filenamePaths[filenamePaths.Length - 1];
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();

            /* SaveFileDialog Sdialog = new SaveFileDialog();
             Sdialog.Filter = "all (*.*) | *.*";
             if (Sdialog.ShowDialog() == DialogResult.OK)
             {
                 File.WriteAllText(Sdialog.FileName, Ritch.Text);
                 _openFile = Sdialog.FileName;
             }
            */
        }


        private string getFileExt(string fileName)
        {
            string[] fileParts = fileName.Split('.');
            return fileParts[fileParts.Length - 1];
        }
        private void saveFile()
        {
            if (tbCtrl.TabCount != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = tbCtrl.SelectedTab.Text;
                saveFileDialog.Filter = "RichTextFormat (*.rtf)|*.rtf|Text Files |*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileMode mode;
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        mode = FileMode.Truncate;
                    }
                    else
                    {
                        mode = FileMode.CreateNew;
                    }

                    string fileName = saveFileDialog.FileName;

                    using (Stream s = File.Open(fileName, mode))
                    using (StreamWriter sw = new StreamWriter(s))
                    {


                        if (getFileExt(fileName) == "rtf")
                        {
                            sw.Write(GetRichTextBox().Rtf);
                        }
                        else
                        {
                            sw.Write(GetRichTextBox().Text);
                        }

                    }
                    tbCtrl.SelectedTab.Text = getJustFileName(saveFileDialog.FileName);

                }
            }
        }
        private void readFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string fileText = File.ReadAllText(fileName);

                createNewTabPage(getJustFileName(fileName));
                tbCtrl.SelectedTab = tbCtrl.TabPages[tbCtrl.TabPages.Count - 1];

                RichTextBox rtb = GetRichTextBox();

                if (getFileExt(fileName) == "rtf")
                    rtb.Rtf = fileText;
                else
                    rtb.Text = fileText;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   //Otwarcie pliku
               if (OPD.ShowDialog() == DialogResult.Cancel)
                   return;
               string filename = OPD.FileName;
               string fileText = File.ReadAllText(filename);
               Ritch.Text = fileText;
            */
            //openFile();

            OpenFileDialog Fdialog = new OpenFileDialog();
            //Fdialog.Filter = "all (*.*) | *.*";
            Fdialog.Filter = "RichTextFormat (*.rtf)|*.rtf|Text Files |*.txt";


            if (Fdialog.ShowDialog() == DialogResult.OK)
            {
                //Ritch.Text = File.ReadAllText(Fdialog.FileName); //path to the file
                //_openFile = Fdialog.FileName;
                readFile(Fdialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alwaysOnTopModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Czy napewno usuąć", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


        }

        private void deleteAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFile();
        }

        private void deleteSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTabPage("New document");
        }
        void AddToRichText(string name)
        {
            RichTextBox richTextBox = GetRichTextBox();

            if (richTextBox != null)
            {
                // Добавляем текст в RichTextBox
                richTextBox.AppendText(name);
            }
            else
            {
                MessageBox.Show("Create a text file!");
            }
        }
        private void windowColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CL.ShowDialog() == DialogResult.Cancel)
                return;
            //this.BackColor = CL.Color;

        }

        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToRichText("____________________________________");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help newForm = new Help(this);
            //  Help.
            newForm.Show();
        }
        private void setFont()
        {
            RichTextBox rtb = GetRichTextBox();
            if (rtb == null)
                return;
            if (rtb.SelectedText == "")
                return;
            FontDialog fd = new FontDialog();
            fd.Font = rtb.SelectionFont;
            fd.ShowColor = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fd.Font;
            }
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // if (fontDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            // Ritch.Font = fontDialog1.Font;
            setFont();
        }

        private void Ritch_TextChanged(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ritch.ForeColor = Color.White;
            // Ritch.BackColor = Color.DimGray;
            menuStrip1.BackColor = Color.DarkGray;
        }

        private void whiiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ritch.ForeColor = Color.Black;
            // Ritch.BackColor = Color.White;
            menuStrip1.BackColor = Color.SeaShell;
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ritch.Text += DateTime.Now;

        }
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewTabPage("New document");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* 
              try
              {
                  File.WriteAllText(_openFile, Ritch.Text);
              }
              catch (ArgumentException)
              {
                  MessageBox.Show("Save error");
              }
            */

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pDocument = new PrintDocument();
            pDocument.PrintPage += PrintPageH;
            PrintDialog pDialog = new PrintDialog();
            pDialog.Document = pDocument;
            if (pDialog.ShowDialog() == DialogResult.OK)
                pDialog.Document.Print();

        }
        public void PrintPageH(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(Ritch.Text, Ritch.Font, Brushes.Black, 0, 0);
        }

        private void dotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToRichText("...........................................");
        }

        private void uppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings newForm = new FormSettings();
            newForm.ShowDialog();
        }
        private RichTextBox GetRichTextBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tbCtrl.SelectedTab;

            if (tp != null)
                rtb = tp.Controls[0] as RichTextBox;

            return rtb;
        }

        private void createNewTabPage(string caption)
        {
            TabPage tp = new TabPage(caption);
            tp.BorderStyle = BorderStyle.None;
            RichTextBox rtb = new RichTextBox();
            rtb.BorderStyle = BorderStyle.None;
            rtb.Dock = DockStyle.Fill;

            tp.Controls.Add(rtb);
            tbCtrl.TabPages.Add(tp);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            createNewTabPage("New document");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void openFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string file in files)
                {
                    string fileExt = getFileExt(file);
                    if (fileExt == "rtf" || fileExt == "txt")
                        readFile(file);
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFolder();
        }
        private void closeFile()
        {

            if (tbCtrl.TabCount != 0)
            {
                if (MessageBox.Show("Save the text file?" + tbCtrl.SelectedTab.Text,
                    "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    saveFile();
                tbCtrl.TabPages.Remove(tbCtrl.SelectedTab);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            closeFile();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Cut();
        }

        private void MenuICopy_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }
        private void MenuPaste_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }
        private Color getColor(Color prevColor)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = prevColor;
            Color color = prevColor;
            if (cd.ShowDialog() == DialogResult.OK)
                color = cd.Color;
            return color;
        }

        private void setFontColor()
        {
            RichTextBox rtb = GetRichTextBox();
            if (rtb != null && rtb.SelectedText != "")
            {
                rtb.SelectionColor = getColor(rtb.SelectionColor);
            }
        }
        private void MenuColorText_Click(object sender, EventArgs e)
        {
            setFontColor();
        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void MenuCloseFile_Click(object sender, EventArgs e)
        {
            closeFile();
        }

        private void alignTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ChangeTabPageTitle(TabPage tabPage, string newTitle)
        {
            if (tabPage != null)
            {
                tabPage.Text = newTitle;
            }
        }

        public static class InputBox
        {
            public static string Show(string prompt, string title = "")
            {
                Form form = new Form();
                form.Text = title;

                Label label = new Label();
                label.Text = prompt;
                label.SetBounds(9, 20, 372, 13);

                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.SetBounds(12, 36, 372, 20);

                System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
                buttonOk.Text = "OK";
                buttonOk.DialogResult = DialogResult.OK;
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();
                buttonCancel.Text = "Cancel";
                buttonCancel.DialogResult = DialogResult.Cancel;
                buttonCancel.SetBounds(309, 72, 75, 23);
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new System.Drawing.Size(396, 107);
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                return form.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ChangeTabPageTitle(selectedTabPage, "Новое название вкладки");
            //  TabPage tp = new TabPage(caption);
            string result = InputBox.Show("Enter a new file name:", "File name");
            //Console.WriteLine("Введенное имя: " + result);

            TabPage selectedTabPage = tbCtrl.SelectedTab;
            if (selectedTabPage != null)
            {
                // Изменяем название вкладки
                selectedTabPage.Text = result;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichTextBox().Paste();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddToRichText("№");
        }
    }


}