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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        settingsToolStripMenuItem = new ToolStripMenuItem();
        colorToolStripMenuItem = new ToolStripMenuItem();
        fontToolStripMenuItem = new ToolStripMenuItem();
        languageToolStripMenuItem = new ToolStripMenuItem();
        bulgarianLanguageToolStripMenuItem = new ToolStripMenuItem();
        englishLanguageToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        aboutStudentToolStripMenuItem = new ToolStripMenuItem();
        colorDialog1 = new ColorDialog();
        fontDialog1 = new FontDialog();
        timer1 = new System.Windows.Forms.Timer(components);
        saveFileDialog1 = new SaveFileDialog();
        canvasBox = new PictureBox();
        panel1 = new Panel();
        applyTextButton = new Button();
        greetingTextBox = new TextBox();
        greetingTextBoxLabel = new Label();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)canvasBox).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        resources.ApplyResources(menuStrip1, "menuStrip1");
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, languageToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Name = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsToolStripMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        // 
        // saveAsToolStripMenuItem
        // 
        resources.ApplyResources(saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
        // 
        // exitToolStripMenuItem
        // 
        resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // settingsToolStripMenuItem
        // 
        resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
        settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fontToolStripMenuItem });
        settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
        // 
        // colorToolStripMenuItem
        // 
        resources.ApplyResources(colorToolStripMenuItem, "colorToolStripMenuItem");
        colorToolStripMenuItem.Name = "colorToolStripMenuItem";
        colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
        // 
        // fontToolStripMenuItem
        // 
        resources.ApplyResources(fontToolStripMenuItem, "fontToolStripMenuItem");
        fontToolStripMenuItem.Name = "fontToolStripMenuItem";
        fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
        // 
        // languageToolStripMenuItem
        // 
        resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
        languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bulgarianLanguageToolStripMenuItem, englishLanguageToolStripMenuItem });
        languageToolStripMenuItem.Name = "languageToolStripMenuItem";
        // 
        // bulgarianLanguageToolStripMenuItem
        // 
        resources.ApplyResources(bulgarianLanguageToolStripMenuItem, "bulgarianLanguageToolStripMenuItem");
        bulgarianLanguageToolStripMenuItem.Name = "bulgarianLanguageToolStripMenuItem";
        bulgarianLanguageToolStripMenuItem.Click += bulgarianLanguageToolStripMenuItem_Click;
        // 
        // englishLanguageToolStripMenuItem
        // 
        resources.ApplyResources(englishLanguageToolStripMenuItem, "englishLanguageToolStripMenuItem");
        englishLanguageToolStripMenuItem.Name = "englishLanguageToolStripMenuItem";
        englishLanguageToolStripMenuItem.Click += englishLanguageToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutStudentToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        // 
        // aboutStudentToolStripMenuItem
        // 
        resources.ApplyResources(aboutStudentToolStripMenuItem, "aboutStudentToolStripMenuItem");
        aboutStudentToolStripMenuItem.Name = "aboutStudentToolStripMenuItem";
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
        resources.ApplyResources(saveFileDialog1, "saveFileDialog1");
        // 
        // canvasBox
        // 
        resources.ApplyResources(canvasBox, "canvasBox");
        canvasBox.Name = "canvasBox";
        canvasBox.TabStop = false;
        canvasBox.Paint += canvasBox_Paint;
        // 
        // panel1
        // 
        resources.ApplyResources(panel1, "panel1");
        panel1.BackColor = SystemColors.ControlLight;
        panel1.Controls.Add(applyTextButton);
        panel1.Controls.Add(greetingTextBox);
        panel1.Controls.Add(greetingTextBoxLabel);
        panel1.Name = "panel1";
        // 
        // applyTextButton
        // 
        resources.ApplyResources(applyTextButton, "applyTextButton");
        applyTextButton.Name = "applyTextButton";
        applyTextButton.UseVisualStyleBackColor = true;
        applyTextButton.Click += applyTextButton_Click;
        // 
        // greetingTextBox
        // 
        resources.ApplyResources(greetingTextBox, "greetingTextBox");
        greetingTextBox.Name = "greetingTextBox";
        // 
        // greetingTextBoxLabel
        // 
        resources.ApplyResources(greetingTextBoxLabel, "greetingTextBoxLabel");
        greetingTextBoxLabel.Name = "greetingTextBoxLabel";
        // 
        // Form1
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(canvasBox);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)canvasBox).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    private System.Windows.Forms.Label greetingTextBoxLabel;
    private System.Windows.Forms.TextBox greetingTextBox;
    private System.Windows.Forms.Button applyTextButton;
    private System.Windows.Forms.Panel panel1;
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
