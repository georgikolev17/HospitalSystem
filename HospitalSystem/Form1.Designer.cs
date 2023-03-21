namespace HospitalSystem
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
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(407, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 459);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.MediumTurquoise;
            button2.Location = new Point(206, 377);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 7;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(25, 379);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
            label4.TabIndex = 6;
            label4.Text = "Don't Have Account?";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumTurquoise;
            button1.Location = new Point(109, 277);
            button1.Name = "button1";
            button1.Size = new Size(175, 63);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(25, 233);
            label3.Name = "label3";
            label3.Size = new Size(339, 20);
            label3.TabIndex = 4;
            label3.Text = "-------------------------------------------------------";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(50, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 24);
            textBox2.TabIndex = 3;
            textBox2.Text = "Password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(25, 144);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 2;
            label2.Text = "-------------------------------------------------------";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(50, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 24);
            textBox1.TabIndex = 1;
            textBox1.Text = "UserName";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(130, 39);
            label1.Name = "label1";
            label1.Size = new Size(124, 40);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.v870_tang_36;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(948, 602);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}