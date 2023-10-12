namespace Microsoft_Word_Clone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TextEditor = new RichTextBox();
            Boldbtn = new Button();
            Italicbtn = new Button();
            SuspendLayout();
            // 
            // TextEditor
            // 
            resources.ApplyResources(TextEditor, "TextEditor");
            TextEditor.Name = "TextEditor";
            // 
            // Boldbtn
            // 
            resources.ApplyResources(Boldbtn, "Boldbtn");
            Boldbtn.BackColor = Color.Gainsboro;
            Boldbtn.Name = "Boldbtn";
            Boldbtn.UseVisualStyleBackColor = false;
            Boldbtn.Click += Boldbtn_Click;
            // 
            // Italicbtn
            // 
            resources.ApplyResources(Italicbtn, "Italicbtn");
            Italicbtn.Name = "Italicbtn";
            Italicbtn.UseVisualStyleBackColor = true;
            Italicbtn.Click += Italicbtn_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            Controls.Add(Italicbtn);
            Controls.Add(Boldbtn);
            Controls.Add(TextEditor);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TextEditor;
        private Button Boldbtn;
        private Button Italicbtn;
    }
}