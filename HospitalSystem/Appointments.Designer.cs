namespace HospitalSystem
{
    partial class Appointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointments));
            label1 = new Label();
            label11 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(158, 242);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 0;
            label1.Text = "Choose doctor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.MediumTurquoise;
            label11.Location = new Point(94, 44);
            label11.Name = "label11";
            label11.Size = new Size(307, 38);
            label11.TabIndex = 0;
            label11.Text = "MAKE APPOINTMENT";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.ForeColor = SystemColors.WindowFrame;
            maskedTextBox1.Location = new Point(94, 171);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(307, 31);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumTurquoise;
            label5.Location = new Point(213, 137);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 12;
            label5.Text = "Date:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumTurquoise;
            button1.Location = new Point(94, 365);
            button1.Name = "button1";
            button1.Size = new Size(307, 65);
            button1.TabIndex = 14;
            button1.Text = "COMPLETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(307, 33);
            comboBox1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(278, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 476);
            panel1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumTurquoise;
            label4.Location = new Point(49, 82);
            label4.Name = "label4";
            label4.Size = new Size(399, 20);
            label4.TabIndex = 16;
            label4.Text = "-----------------------------------------------------------------";
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.v870_tang_36;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 690);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS | Appointments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label11;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Button button1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label4;
    }
}