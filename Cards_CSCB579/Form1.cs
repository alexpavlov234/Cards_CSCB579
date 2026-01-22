using System.ComponentModel;
using System.Globalization;
using System.Drawing.Drawing2D;

namespace Cards_CSCB579;

public partial class Form1 : Form
{
    private string _greetingText = "Честит празник";

    private Font _greetingTextFont = new Font("Comic Sans MS", 24, FontStyle.Bold);
    private Color _greetingTextColor = Color.DarkRed;

    public Form1()
    {
        InitializeComponent();
    }

    private void canvasBox_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = this.canvasBox.ClientRectangle;

        using (LinearGradientBrush backgrountBrush = new LinearGradientBrush(rect, Color.PeachPuff, Color.Yellow, 45F))
        {
            e.Graphics.FillRectangle(backgrountBrush, rect);
        }

        using (Brush ellipseBrush1 = new SolidBrush(Color.FromArgb(100, Color.DeepPink)))
        using (Brush ellipseBrush2 = new SolidBrush(Color.FromArgb(100, Color.Orange)))
        {
            e.Graphics.FillEllipse(ellipseBrush1, -50, -50, 150, 150);
            e.Graphics.FillEllipse(ellipseBrush2, rect.Width - 100, rect.Height - 100, 150, 150);
        }

        using (Pen borderPen = new Pen(Color.Gold, 10))
        {
            e.Graphics.DrawRectangle(borderPen, 5, 5, rect.Width - 10, rect.Height - 10);
        }

        SizeF textBoxSizeMeasurement = e.Graphics.MeasureString(this._greetingText, this._greetingTextFont);
        float xOfText = (this.canvasBox.Width - textBoxSizeMeasurement.Width) / 2.0f;
        float yOfText = (this.canvasBox.Height - textBoxSizeMeasurement.Height) / 2.0f;

        using (Brush shadowBrush = new SolidBrush(Color.FromArgb(80, Color.Black)))
        {
            e.Graphics.DrawString(this._greetingText, this._greetingTextFont, shadowBrush, xOfText + 4, yOfText + 4);
        }

        using (Brush mainTextBrush = new SolidBrush(this._greetingTextColor))
        {
            e.Graphics.DrawString(this._greetingText, this._greetingTextFont, mainTextBrush, xOfText, yOfText);
        }
    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
    private void colorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (this.colorDialog1.ShowDialog() != DialogResult.OK)
            return;

        this._greetingTextColor = this.colorDialog1.Color;

        this.canvasBox.Invalidate();
    }
    private void fontToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (this.fontDialog1.ShowDialog() != DialogResult.OK)
            return;

        this._greetingTextFont = this.fontDialog1.Font;

        this.canvasBox.Invalidate();
    }
    private void bulgarianLanguageToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ChangeLanguage("bg-BG");
    }

    private void englishLanguageToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ChangeLanguage("en");
    }
    private void aboutStudentToolStripMenuItem_Click(object sender, EventArgs e)
    {
        string info = "Курс: CSCB579 Програмиране на приложения с Microsoft Visual C# .NET\n\n" +
                      "Студент: Александър Александров Павлов\n" +
                      "Фак. номер: F112657\n\n" +
                      "Проект: Програма за създаване на картички";
        MessageBox.Show(info, "За студента", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void timer1_Tick(object sender, EventArgs e)
    {

    }

    private void applyTextButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(greetingTextBox.Text))
        {
            this._greetingText = greetingTextBox.Text;
            canvasBox.Invalidate();
        }
        else
        {
            MessageBox.Show("Моля, въведете текст!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void ChangeLanguage(string lang)
    {
        CultureInfo culture = new CultureInfo(lang);
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

        resources.ApplyResources(this, "$this");


        foreach (Control c in this.Controls)
        {
            resources.ApplyResources(c, c.Name);

            if (c is MenuStrip menuStrip)
            {
                foreach (ToolStripItem item in menuStrip.Items)
                {
                    resources.ApplyResources(item, item.Name);
                    if (item is ToolStripMenuItem menuItem)
                    {
                        foreach (ToolStripItem subItem in menuItem.DropDownItems)
                        {
                            resources.ApplyResources(subItem, subItem.Name);
                        }
                    }
                }
            }

            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    resources.ApplyResources(child, child.Name);
                    if (child.HasChildren)
                    {
                        foreach (Control subChild in child.Controls)
                        {
                            resources.ApplyResources(subChild, subChild.Name);
                        }
                    }
                }
            }
        }
    }
}
