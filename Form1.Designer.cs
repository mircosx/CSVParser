namespace ParserCSV
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
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog2 = new OpenFileDialog();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Text Files";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(228, 8);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 1;
            button1.Text = "Apri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(300, 136);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 2;
            button2.Text = "Verifica";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(27, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "\"";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Location = new Point(228, 71);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 5;
            button3.Text = "Apri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "File sorgente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "File risultato";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 136);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 8;
            label3.Text = "Qualificatore testo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 158);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(25, 23);
            textBox4.TabIndex = 9;
            textBox4.Text = ";";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 136);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 10;
            label4.Text = "Separatore colonne";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(148, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(227, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Apri file di controllo dopo la creazione";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 215);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Elabora CSV";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog2;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private CheckBox checkBox1;
    }
}