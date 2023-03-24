namespace HospitalSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1=new Panel();
            button2=new Button();
            label4=new Label();
            button1=new Button();
            label3=new Label();
            textBox2=new TextBox();
            label2=new Label();
            textBox1=new TextBox();
            label1=new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
            panel1.BackColor=Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor=Color.Black;
            panel1.Location=new Point(321, 90);
            panel1.Name="panel1";
            panel1.Size=new Size(395, 471);
            panel1.TabIndex=0;
            // 
            // button2
            // 
            button2.FlatStyle=FlatStyle.Flat;
            button2.Font=new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor=Color.MediumTurquoise;
            button2.Location=new Point(219, 385);
            button2.Name="button2";
            button2.Size=new Size(83, 37);
            button2.TabIndex=7;
            button2.Text="Sign Up";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor=Color.MediumTurquoise;
            label4.Location=new Point(38, 391);
            label4.Name="label4";
            label4.Size=new Size(175, 23);
            label4.TabIndex=6;
            label4.Text="Don't Have Account?";
            label4.Click+=label4_Click;
            // 
            // button1
            // 
            button1.BackColor=Color.WhiteSmoke;
            button1.FlatStyle=FlatStyle.Flat;
            button1.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor=Color.MediumTurquoise;
            button1.Location=new Point(104, 289);
            button1.Name="button1";
            button1.Size=new Size(175, 63);
            button1.TabIndex=0;
            button1.TabStop=false;
            button1.Text="Log in";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor=Color.MediumTurquoise;
            label3.Location=new Point(25, 233);
            label3.Name="label3";
            label3.Size=new Size(339, 20);
            label3.TabIndex=4;
            label3.Text="-------------------------------------------------------";
            // 
            // textBox2
            // 
            textBox2.BorderStyle=BorderStyle.None;
            textBox2.Font=new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor=SystemColors.WindowFrame;
            textBox2.Location=new Point(50, 205);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(283, 24);
            textBox2.TabIndex=3;
            textBox2.TabStop=false;
            textBox2.Text="Password";
            textBox2.TextAlign=HorizontalAlignment.Center;
            textBox2.Enter+=textBox2_Enter;
            textBox2.Leave+=textBox2_Leave;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor=Color.MediumTurquoise;
            label2.Location=new Point(25, 144);
            label2.Name="label2";
            label2.Size=new Size(339, 20);
            label2.TabIndex=2;
            label2.Text="-------------------------------------------------------";
            // 
            // textBox1
            // 
            textBox1.BorderStyle=BorderStyle.None;
            textBox1.Font=new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor=SystemColors.WindowFrame;
            textBox1.Location=new Point(50, 117);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(283, 24);
            textBox1.TabIndex=1;
            textBox1.TabStop=false;
            textBox1.Text="Email";
            textBox1.TextAlign=HorizontalAlignment.Center;
            textBox1.TextChanged+=textBox1_TextChanged;
            textBox1.Enter+=textBox1_Enter;
            textBox1.Leave+=textBox1_Leave;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Arial", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor=Color.MediumTurquoise;
            label1.Location=new Point(130, 39);
            label1.Name="label1";
            label1.Size=new Size(129, 38);
            label1.TabIndex=0;
            label1.Text="LOG IN";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackgroundImage=Properties.Resources.v870_tang_36;
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(1004, 690);
            Controls.Add(panel1);
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            MinimizeBox=false;
            Name="LoginForm";
            StartPosition=FormStartPosition.CenterScreen;
            Text="HMS | Log In";
            Load+=LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}