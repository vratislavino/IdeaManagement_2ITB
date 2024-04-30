namespace IdeaManagement
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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 38;
            listBox1.Location = new Point(12, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(349, 802);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 48);
            label1.TabIndex = 1;
            label1.Text = "Nápady";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(367, 60);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nadpis";
            textBox1.Size = new Size(426, 55);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(367, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(426, 322);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(367, 449);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 50);
            textBox2.TabIndex = 4;
            textBox2.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(595, 449);
            button1.Name = "button1";
            button1.Size = new Size(198, 94);
            button1.TabIndex = 5;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(595, 549);
            button2.Name = "button2";
            button2.Size = new Size(198, 94);
            button2.TabIndex = 6;
            button2.Text = "Odstranit";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 901);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
