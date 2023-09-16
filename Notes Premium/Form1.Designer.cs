namespace Notes_Premium
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newWindowToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            MenuCloseFile = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem1 = new ToolStripMenuItem();
            themeToolStripMenuItem1 = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            whiiteToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            MenuICopy = new ToolStripMenuItem();
            MenuPaste = new ToolStripMenuItem();
            MenuColorText = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            alwaysOnTopModeToolStripMenuItem = new ToolStripMenuItem();
            normalModeToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            linesToolStripMenuItem = new ToolStripMenuItem();
            dotsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            windowColorToolStripMenuItem = new ToolStripMenuItem();
            alignTextToolStripMenuItem = new ToolStripMenuItem();
            letterSizeToolStripMenuItem = new ToolStripMenuItem();
            uppercaseToolStripMenuItem = new ToolStripMenuItem();
            lowercaseToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            settigsToolStripMenuItem = new ToolStripMenuItem();
            defaultSettingsToolStripMenuItem = new ToolStripMenuItem();
            OPD = new OpenFileDialog();
            SD = new SaveFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteAllTextToolStripMenuItem = new ToolStripMenuItem();
            deleteSelectedTextToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            fontDialog1 = new FontDialog();
            CL = new ColorDialog();
            tbCtrl = new TabControl();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, insertToolStripMenuItem, textToolStripMenuItem, helpToolStripMenuItem, settigsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1063, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newWindowToolStripMenuItem, openToolStripMenuItem, toolStripMenuItem1, MenuCloseFile, saveToolStripMenuItem, saveAsToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newWindowToolStripMenuItem
            // 
            newWindowToolStripMenuItem.BackColor = SystemColors.Control;
            newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            newWindowToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newWindowToolStripMenuItem.Size = new Size(190, 22);
            newWindowToolStripMenuItem.Text = "New";
            newWindowToolStripMenuItem.Click += newWindowToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.Control;
            openToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(190, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(190, 22);
            toolStripMenuItem1.Text = "Open folder";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // MenuCloseFile
            // 
            MenuCloseFile.BackColor = SystemColors.Control;
            MenuCloseFile.Name = "MenuCloseFile";
            MenuCloseFile.Size = new Size(190, 22);
            MenuCloseFile.Text = "Close file";
            MenuCloseFile.Click += MenuCloseFile_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.BackColor = SystemColors.Control;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(190, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = SystemColors.Control;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(190, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.BackColor = SystemColors.Control;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            printToolStripMenuItem.Size = new Size(190, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.Control;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(190, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem1, themeToolStripMenuItem1, dateTimeToolStripMenuItem, toolStripMenuItem2, MenuICopy, MenuPaste, MenuColorText });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.BackColor = SystemColors.Control;
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.F;
            fontToolStripMenuItem1.Size = new Size(146, 22);
            fontToolStripMenuItem1.Text = "Font";
            fontToolStripMenuItem1.Click += fontToolStripMenuItem1_Click;
            // 
            // themeToolStripMenuItem1
            // 
            themeToolStripMenuItem1.BackColor = SystemColors.Control;
            themeToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, whiiteToolStripMenuItem });
            themeToolStripMenuItem1.Name = "themeToolStripMenuItem1";
            themeToolStripMenuItem1.Size = new Size(146, 22);
            themeToolStripMenuItem1.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(108, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // whiiteToolStripMenuItem
            // 
            whiiteToolStripMenuItem.Name = "whiiteToolStripMenuItem";
            whiiteToolStripMenuItem.Size = new Size(108, 22);
            whiiteToolStripMenuItem.Text = "Whiite";
            whiiteToolStripMenuItem.Click += whiiteToolStripMenuItem_Click;
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.BackColor = SystemColors.Control;
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.ShortcutKeys = Keys.F5;
            dateTimeToolStripMenuItem.Size = new Size(146, 22);
            dateTimeToolStripMenuItem.Text = "Date Time";
            dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = SystemColors.Control;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(146, 22);
            toolStripMenuItem2.Text = "Cut";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // MenuICopy
            // 
            MenuICopy.Name = "MenuICopy";
            MenuICopy.Size = new Size(146, 22);
            MenuICopy.Text = "Copy";
            MenuICopy.Click += MenuICopy_Click;
            // 
            // MenuPaste
            // 
            MenuPaste.Name = "MenuPaste";
            MenuPaste.Size = new Size(146, 22);
            MenuPaste.Text = "Paste";
            MenuPaste.Click += MenuPaste_Click;
            // 
            // MenuColorText
            // 
            MenuColorText.Name = "MenuColorText";
            MenuColorText.Size = new Size(146, 22);
            MenuColorText.Text = "Color Text";
            MenuColorText.Click += MenuColorText_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopModeToolStripMenuItem, normalModeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // alwaysOnTopModeToolStripMenuItem
            // 
            alwaysOnTopModeToolStripMenuItem.BackColor = SystemColors.Control;
            alwaysOnTopModeToolStripMenuItem.Name = "alwaysOnTopModeToolStripMenuItem";
            alwaysOnTopModeToolStripMenuItem.Size = new Size(183, 22);
            alwaysOnTopModeToolStripMenuItem.Text = "Always on top mode";
            alwaysOnTopModeToolStripMenuItem.Click += alwaysOnTopModeToolStripMenuItem_Click;
            // 
            // normalModeToolStripMenuItem
            // 
            normalModeToolStripMenuItem.BackColor = SystemColors.Control;
            normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            normalModeToolStripMenuItem.Size = new Size(183, 22);
            normalModeToolStripMenuItem.Text = "Normal Mode";
            normalModeToolStripMenuItem.Click += normalModeToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { linesToolStripMenuItem, dotsToolStripMenuItem, toolStripMenuItem3 });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(48, 20);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // linesToolStripMenuItem
            // 
            linesToolStripMenuItem.BackColor = SystemColors.Control;
            linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            linesToolStripMenuItem.Size = new Size(98, 22);
            linesToolStripMenuItem.Text = "lines";
            linesToolStripMenuItem.Click += linesToolStripMenuItem_Click;
            // 
            // dotsToolStripMenuItem
            // 
            dotsToolStripMenuItem.BackColor = SystemColors.Control;
            dotsToolStripMenuItem.Name = "dotsToolStripMenuItem";
            dotsToolStripMenuItem.Size = new Size(98, 22);
            dotsToolStripMenuItem.Text = "Dots";
            dotsToolStripMenuItem.Click += dotsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(98, 22);
            toolStripMenuItem3.Text = "№";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { windowColorToolStripMenuItem, alignTextToolStripMenuItem, letterSizeToolStripMenuItem });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(40, 20);
            textToolStripMenuItem.Text = "Text";
            // 
            // windowColorToolStripMenuItem
            // 
            windowColorToolStripMenuItem.BackColor = SystemColors.Control;
            windowColorToolStripMenuItem.Name = "windowColorToolStripMenuItem";
            windowColorToolStripMenuItem.Size = new Size(148, 22);
            windowColorToolStripMenuItem.Text = "Window color";
            windowColorToolStripMenuItem.Click += windowColorToolStripMenuItem_Click;
            // 
            // alignTextToolStripMenuItem
            // 
            alignTextToolStripMenuItem.BackColor = SystemColors.Control;
            alignTextToolStripMenuItem.Name = "alignTextToolStripMenuItem";
            alignTextToolStripMenuItem.Size = new Size(148, 22);
            alignTextToolStripMenuItem.Text = "Align text";
            alignTextToolStripMenuItem.Click += alignTextToolStripMenuItem_Click;
            // 
            // letterSizeToolStripMenuItem
            // 
            letterSizeToolStripMenuItem.BackColor = SystemColors.Control;
            letterSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uppercaseToolStripMenuItem, lowercaseToolStripMenuItem });
            letterSizeToolStripMenuItem.Name = "letterSizeToolStripMenuItem";
            letterSizeToolStripMenuItem.Size = new Size(148, 22);
            letterSizeToolStripMenuItem.Text = "Letter size";
            // 
            // uppercaseToolStripMenuItem
            // 
            uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            uppercaseToolStripMenuItem.Size = new Size(129, 22);
            uppercaseToolStripMenuItem.Text = "Uppercase";
            uppercaseToolStripMenuItem.Click += uppercaseToolStripMenuItem_Click;
            // 
            // lowercaseToolStripMenuItem
            // 
            lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            lowercaseToolStripMenuItem.Size = new Size(129, 22);
            lowercaseToolStripMenuItem.Text = "Lowercase";
            lowercaseToolStripMenuItem.Click += lowercaseToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = SystemColors.Control;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(156, 22);
            aboutToolStripMenuItem.Text = "About program";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // settigsToolStripMenuItem
            // 
            settigsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defaultSettingsToolStripMenuItem });
            settigsToolStripMenuItem.Name = "settigsToolStripMenuItem";
            settigsToolStripMenuItem.Size = new Size(54, 20);
            settigsToolStripMenuItem.Text = "Settigs";
            // 
            // defaultSettingsToolStripMenuItem
            // 
            defaultSettingsToolStripMenuItem.Name = "defaultSettingsToolStripMenuItem";
            defaultSettingsToolStripMenuItem.Size = new Size(156, 22);
            defaultSettingsToolStripMenuItem.Text = "Default settings";
            defaultSettingsToolStripMenuItem.Click += defaultSettingsToolStripMenuItem_Click;
            // 
            // OPD
            // 
            OPD.FileName = "OPD";
            OPD.Filter = "(*.txt)|*.txt";
            OPD.InitialDirectory = "C:";
            OPD.RestoreDirectory = true;
            // 
            // SD
            // 
            SD.Filter = "(*.txt)|*.txt";
            SD.InitialDirectory = "C:";
            SD.Title = "Open file txt";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteAllTextToolStripMenuItem, deleteSelectedTextToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(153, 114);
            // 
            // deleteAllTextToolStripMenuItem
            // 
            deleteAllTextToolStripMenuItem.Name = "deleteAllTextToolStripMenuItem";
            deleteAllTextToolStripMenuItem.Size = new Size(152, 22);
            deleteAllTextToolStripMenuItem.Text = "Close File";
            deleteAllTextToolStripMenuItem.Click += deleteAllTextToolStripMenuItem_Click;
            // 
            // deleteSelectedTextToolStripMenuItem
            // 
            deleteSelectedTextToolStripMenuItem.Name = "deleteSelectedTextToolStripMenuItem";
            deleteSelectedTextToolStripMenuItem.Size = new Size(152, 22);
            deleteSelectedTextToolStripMenuItem.Text = "Create new file";
            deleteSelectedTextToolStripMenuItem.Click += deleteSelectedTextToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(152, 22);
            cutToolStripMenuItem.Text = "Rename file";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(152, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(152, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 25);
            panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1063, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fontDialog1.MaxSize = 20;
            fontDialog1.MinSize = 10;
            // 
            // tbCtrl
            // 
            tbCtrl.ContextMenuStrip = contextMenuStrip1;
            tbCtrl.Cursor = Cursors.IBeam;
            tbCtrl.Dock = DockStyle.Fill;
            tbCtrl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbCtrl.Location = new Point(0, 49);
            tbCtrl.Name = "tbCtrl";
            tbCtrl.SelectedIndex = 0;
            tbCtrl.Size = new Size(1063, 482);
            tbCtrl.TabIndex = 3;
            tbCtrl.SelectedIndexChanged += tbCtrl_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1063, 531);
            Controls.Add(tbCtrl);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes Premium";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem windowColorToolStripMenuItem;
        private ToolStripMenuItem alignTextToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem alwaysOnTopModeToolStripMenuItem;
        private ToolStripMenuItem normalModeToolStripMenuItem;
        private ToolStripMenuItem linesToolStripMenuItem;
        private ToolStripMenuItem dotsToolStripMenuItem;
        private ToolStripMenuItem letterSizeToolStripMenuItem;
        private ToolStripMenuItem uppercaseToolStripMenuItem;
        private ToolStripMenuItem lowercaseToolStripMenuItem;
        private OpenFileDialog OPD;
        private SaveFileDialog SD;
        private Panel panel1;
        private FontDialog fontDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteAllTextToolStripMenuItem;
        private ToolStripMenuItem deleteSelectedTextToolStripMenuItem;
        private ColorDialog CL;
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem themeToolStripMenuItem1;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem whiiteToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem settigsToolStripMenuItem;
        private ToolStripMenuItem defaultSettingsToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private TabControl tbCtrl;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem MenuICopy;
        private ToolStripMenuItem MenuPaste;
        private ToolStripMenuItem MenuColorText;
        private ToolStripMenuItem MenuCloseFile;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}