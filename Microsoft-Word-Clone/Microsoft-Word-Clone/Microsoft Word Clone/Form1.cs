namespace Microsoft_Word_Clone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Boldbtn.Text = "Bold";

            Italicbtn.Text = "Italic";
            
        }

        public bool Bold { get; set; } = false;
        public bool Italic { get; set; } = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            TextEditor.Size = new System.Drawing.Size(1134, 630);
        }

        private void Boldbtn_Click(object sender, EventArgs e)
        {



            if (Bold)
            {
                TextEditor.SelectionFont = new System.Drawing.Font(TextEditor.Font, FontStyle.Regular);
                Bold = false;
                Boldbtn.BackColor = System.Drawing.Color.Gainsboro;
            }
            else
            {
                TextEditor.SelectionFont = new System.Drawing.Font(TextEditor.Font, FontStyle.Bold);
                Bold = true;
                Boldbtn.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void Italicbtn_Click(object sender, EventArgs e)
        {
          

      
            if (Italic)
            {
                TextEditor.SelectionFont = new System.Drawing.Font(TextEditor.Font, FontStyle.Regular);
                Italic = false;
            Italicbtn.BackColor = System.Drawing.Color.Gainsboro;
            }
            else
            {
                TextEditor.SelectionFont = new System.Drawing.Font(TextEditor.Font, FontStyle.Italic);
                Italic = true;
                Boldbtn.BackColor = System.Drawing.Color.Gray;
            }



        }
    }
}
