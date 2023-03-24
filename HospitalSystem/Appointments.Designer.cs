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
            panel1 = new Panel();
            label11 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label3 = new Label();
            button1 = new Button();
            Speciality = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            Choose = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(406, 348);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 0;
            label1.Text = "Choose doctor:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(label11);
            panel1.Location = new Point(-9, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 100);
            panel1.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(363, 38);
            label11.Name = "label11";
            label11.Size = new Size(307, 38);
            label11.TabIndex = 0;
            label11.Text = "MAKE APPOINTMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(-125, 85);
            label2.Name = "label2";
            label2.Size = new Size(1230, 25);
            label2.TabIndex = 5;
            label2.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Speciality, DoctorName, Choose });
            dataGridView1.Location = new Point(23, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(960, 126);
            dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(354, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 31);
            textBox1.TabIndex = 8;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.ForeColor = SystemColors.WindowFrame;
            maskedTextBox1.Location = new Point(354, 268);
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
            label5.Location = new Point(241, 265);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 12;
            label5.Text = "Date:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(184, 186);
            label3.Name = "label3";
            label3.Size = new Size(127, 31);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumTurquoise;
            button1.Location = new Point(376, 567);
            button1.Name = "button1";
            button1.Size = new Size(266, 65);
            button1.TabIndex = 14;
            button1.Text = "COMPLETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Speciality
            // 
            Speciality.HeaderText = "Speciality";
            Speciality.MinimumWidth = 6;
            Speciality.Name = "Speciality";
            Speciality.Width = 300;
            // 
            // DoctorName
            // 
            DoctorName.HeaderText = "Doctor Name";
            DoctorName.MinimumWidth = 6;
            DoctorName.Name = "DoctorName";
            DoctorName.Width = 300;
            // 
            // Choose
            // 
            Choose.HeaderText = "Choose";
            Choose.MinimumWidth = 6;
            Choose.Name = "Choose";
            Choose.Text = "Choose";
            Choose.UseColumnTextForButtonValue = true;
            Choose.Width = 300;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1004, 690);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMS | Appointments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label3;
        private Button button1;
        private DataGridViewTextBoxColumn Speciality;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewButtonColumn Choose;
    }
}