namespace Cards_CSCB579;

public partial class Form1 : Form
{
    private string _greetingText = "Честит празник";
    
    private Font _greetingTextFont = new Font("Arial", 24, FontStyle.Bold);
    private Color _greetingTextColor = Color.Goldenrod;
    
    public Form1()
    {
        InitializeComponent();
    }
    
    private void canvasBox_Paint(object sender, PaintEventArgs e)
    {
        Brush brush = new SolidBrush(this._greetingTextColor);
        SizeF textBoxMeasurement = e.Graphics.MeasureString(this._greetingText, this._greetingTextFont);
        e.Graphics.DrawString(this._greetingText, this._greetingTextFont, brush, ((this.canvasBox.Width - textBoxMeasurement.Width) / 2.0f), 100);
    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void colorToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (this.colorDialog1.ShowDialog() != DialogResult.OK)
            return;
        
        this._greetingTextColor = this.colorDialog1.Color;
            
        this.canvasBox.Invalidate();
    }
    private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
        if(this.fontDialog1.ShowDialog() != DialogResult.OK)
            return;

        this._greetingTextFont = this.fontDialog1.Font;
        
        this.canvasBox.Invalidate();
    }
    private void bulgarianLanguageToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void englishLanguageToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void aboutStudentToolStripMenuItem_Click(object sender, EventArgs e) {
        
    }
    private void timer1_Tick(object sender, EventArgs e) {
        
    }

    private void applyTextButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(this.greetingTextBox.Text))
            return;
        
        this._greetingText = this.greetingTextBox.Text;
        this.canvasBox.Invalidate();
    }
}
