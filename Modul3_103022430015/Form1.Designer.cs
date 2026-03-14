namespace Modul3_103022430015
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label_Saw = new Label();
            label_Sak = new Label();
            label_Naw = new Label();
            textBox1 = new TextBox();
            label_Nak = new Label();
            btn_con = new Button();
            label_Output = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Celcius", "Farenheit", "Kelvin", "Reamur" });
            comboBox1.Location = new Point(52, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Celcius", "Farenheit", "Kelvin", "Reamur" });
            comboBox2.Location = new Point(52, 112);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label_Saw
            // 
            label_Saw.AutoSize = true;
            label_Saw.Location = new Point(52, 79);
            label_Saw.Name = "label_Saw";
            label_Saw.Size = new Size(89, 20);
            label_Saw.TabIndex = 2;
            label_Saw.Text = "Satuan awal";
            label_Saw.Click += label1_Click;
            // 
            // label_Sak
            // 
            label_Sak.AutoSize = true;
            label_Sak.Location = new Point(52, 173);
            label_Sak.Name = "label_Sak";
            label_Sak.Size = new Size(92, 20);
            label_Sak.TabIndex = 3;
            label_Sak.Text = "Satuan Akhir";
            label_Sak.Click += label1_Click_1;
            // 
            // label_Naw
            // 
            label_Naw.AutoSize = true;
            label_Naw.Location = new Point(226, 79);
            label_Naw.Name = "label_Naw";
            label_Naw.Size = new Size(77, 20);
            label_Naw.TabIndex = 4;
            label_Naw.Text = "Nilai Awal";
            label_Naw.Click += label1_Click_2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label_Nak
            // 
            label_Nak.AutoSize = true;
            label_Nak.Location = new Point(226, 173);
            label_Nak.Name = "label_Nak";
            label_Nak.Size = new Size(78, 20);
            label_Nak.TabIndex = 7;
            label_Nak.Text = "Nilai Akhir";
            // 
            // btn_con
            // 
            btn_con.Location = new Point(539, 112);
            btn_con.Name = "btn_con";
            btn_con.Size = new Size(84, 28);
            btn_con.TabIndex = 8;
            btn_con.Text = "Convert";
            btn_con.UseVisualStyleBackColor = true;
            btn_con.Click += btn_con_Click;
            // 
            // label_Output
            // 
            label_Output.Location = new Point(236, 209);
            label_Output.Name = "label_Output";
            label_Output.Size = new Size(249, 23);
            label_Output.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 27);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Output);
            Controls.Add(btn_con);
            Controls.Add(label_Nak);
            Controls.Add(textBox1);
            Controls.Add(label_Naw);
            Controls.Add(label_Sak);
            Controls.Add(label_Saw);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label_Saw;
        private Label label_Sak;
        private Label label_Naw;
        private TextBox textBox1;
        private Label label_Nak;
        private Button btn_con;
        private Label label_Output;
        private TextBox textBox2;
    }
}
