namespace Cards_CSCB579;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        bulgarianLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        englishLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        aboutStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        colorDialog1 = new System.Windows.Forms.ColorDialog();
        fontDialog1 = new System.Windows.Forms.FontDialog();
        timer1 = new System.Windows.Forms.Timer(components);
        saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        canvasBox = new System.Windows.Forms.PictureBox();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)canvasBox).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            fileToolStripMenuItem, settingsToolStripMenuItem, languageToolStripMenuItem, helpToolStripMenuItem
        });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            saveAsToolStripMenuItem, exitToolStripMenuItem
        });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        fileToolStripMenuItem.Text = "Файл";
        fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        saveAsToolStripMenuItem.Text = "Запиши като";
        saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
        exitToolStripMenuItem.Text = "Изход";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // settingsToolStripMenuItem
        // 
        settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            colorToolStripMenuItem, fontToolStripMenuItem
        });
        settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
        settingsToolStripMenuItem.Text = "Настройки";
        // 
        // colorToolStripMenuItem
        // 
        colorToolStripMenuItem.Name = "colorToolStripMenuItem";
        colorToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
        colorToolStripMenuItem.Text = "Цвят";
        colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
        // 
        // fontToolStripMenuItem
        // 
        fontToolStripMenuItem.Name = "fontToolStripMenuItem";
        fontToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
        fontToolStripMenuItem.Text = "Шрифт";
        fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
        // 
        // languageToolStripMenuItem
        // 
        languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            bulgarianLanguageToolStripMenuItem, englishLanguageToolStripMenuItem
        });
        languageToolStripMenuItem.Name = "languageToolStripMenuItem";
        languageToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
        languageToolStripMenuItem.Text = "Език";
        // 
        // bulgarianLanguageToolStripMenuItem
        // 
        bulgarianLanguageToolStripMenuItem.Name = "bulgarianLanguageToolStripMenuItem";
        bulgarianLanguageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
        bulgarianLanguageToolStripMenuItem.Text = "Български";
        bulgarianLanguageToolStripMenuItem.Click += bulgarianLanguageToolStripMenuItem_Click;
        // 
        // englishLanguageToolStripMenuItem
        // 
        englishLanguageToolStripMenuItem.Name = "englishLanguageToolStripMenuItem";
        englishLanguageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
        englishLanguageToolStripMenuItem.Text = "English";
        englishLanguageToolStripMenuItem.Click += englishLanguageToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
        {
            aboutStudentToolStripMenuItem
        });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
        helpToolStripMenuItem.Text = "Помощ";
        // 
        // aboutStudentToolStripMenuItem
        // 
        aboutStudentToolStripMenuItem.Name = "aboutStudentToolStripMenuItem";
        aboutStudentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
        aboutStudentToolStripMenuItem.Text = "За студента";
        aboutStudentToolStripMenuItem.Click += aboutStudentToolStripMenuItem_Click;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 50;
        timer1.Tick += timer1_Tick;
        // 
        // saveFileDialog1
        // 
        saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
        // 
        // canvasBox
        // 
        canvasBox.Dock = System.Windows.Forms.DockStyle.Fill;
        canvasBox.Location = new System.Drawing.Point(0, 24);
        canvasBox.Name = "canvasBox";
        canvasBox.Size = new System.Drawing.Size(800, 426);
        canvasBox.TabIndex = 1;
        canvasBox.TabStop = false;
        canvasBox.Paint += canvasBox_Paint;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(canvasBox);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Програма за създаване на картички";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)canvasBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private System.Windows.Forms.PictureBox canvasBox;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bulgarianLanguageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem englishLanguageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutStudentToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}
