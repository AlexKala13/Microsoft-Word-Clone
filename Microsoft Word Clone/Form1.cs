namespace Microsoft_Word_Clone
{
    public partial class Form1 : Form
    {
        private FontStyle currentStyle = FontStyle.Regular; // current style (regular at start)
        private bool bold = false;
        private bool italic = false;
        private bool underline = false;

        public Form1()
        {
            InitializeComponent();
            Boldbtn.Text = "Bold";
            Italicbtn.Text = "Italic";
            UnderlineBtn.Text = "Underline";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextEditor.Size = new System.Drawing.Size(1134, 630);
        }

        private void Boldbtn_Click(object sender, EventArgs e)
        {
            ToggleBold();
        }

        private void Italicbtn_Click(object sender, EventArgs e)
        {
            ToggleItalic();
        }

        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            ToggleUnderline();
        }

        private void ToggleBold()
        {
            currentStyle = currentStyle ^ FontStyle.Bold; // setting bold

            if (bold) // changing bold btn color
            {
                Boldbtn.BackColor = System.Drawing.Color.Gainsboro;
                bold = false;
            }
            else
            {
                Boldbtn.BackColor = System.Drawing.Color.Gray;
                bold = true;
            }

            UpdateSelectionFont();
        }

        private void ToggleItalic()
        {
            currentStyle = currentStyle ^ FontStyle.Italic; // setting italic

            if (italic) // changing italic btn color
            {
                Italicbtn.BackColor = System.Drawing.Color.Gainsboro;
                italic = false;
            }
            else
            {
                Italicbtn.BackColor = System.Drawing.Color.Gray;
                italic = true;
            }

            UpdateSelectionFont();
        }

        private void ToggleUnderline()
        {
            currentStyle = currentStyle ^ FontStyle.Underline; // setting italic

            if (underline) // changing italic btn color
            {
                UnderlineBtn.BackColor = System.Drawing.Color.Gainsboro;
                underline = false;
            }
            else
            {
                UnderlineBtn.BackColor = System.Drawing.Color.Gray;
                underline = true;
            }

            UpdateSelectionFont();
        }

        private void UpdateSelectionFont()
        {
            TextEditor.SelectionFont = new Font(TextEditor.Font, currentStyle); // setting current style to selected text
        }
      
    }
}
