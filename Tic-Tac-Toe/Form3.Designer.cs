namespace Tic_Tac_Toe
{
    partial class Form3
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

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            textbox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textbox2 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            textbox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textbox3 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            textbox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textbox6 = new TextBox();
            textbox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 57);
            label1.TabIndex = 0;
            label1.Text = "Create Player";
            // 
            // textbox1
            // 
            textbox1.Font = new Font("Microsoft Sans Serif", 12F);
            textbox1.Location = new Point(147, 83);
            textbox1.Multiline = true;
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(157, 28);
            textbox1.TabIndex = 1;
            textbox1.TextChanged += textbox1_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 129);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textbox2
            // 
            textbox2.Font = new Font("Microsoft Sans Serif", 12F);
            textbox2.Location = new Point(147, 129);
            textbox2.Multiline = true;
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(157, 28);
            textbox2.TabIndex = 4;
            textbox2.TextChanged += textbox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cambria", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(435, 9);
            label4.Name = "label4";
            label4.Size = new Size(299, 57);
            label4.TabIndex = 6;
            label4.Text = "Player LogIn";
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(154, 173);
            button2.Name = "button2";
            button2.Size = new Size(150, 31);
            button2.TabIndex = 11;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textbox4
            // 
            textbox4.Font = new Font("Microsoft Sans Serif", 12F);
            textbox4.Location = new Point(567, 129);
            textbox4.Multiline = true;
            textbox4.Name = "textbox4";
            textbox4.Size = new Size(157, 28);
            textbox4.TabIndex = 10;
            textbox4.TextChanged += textbox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 129);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 9;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(442, 83);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 8;
            label6.Text = "Username:";
            // 
            // textbox3
            // 
            textbox3.Font = new Font("Microsoft Sans Serif", 12F);
            textbox3.Location = new Point(567, 83);
            textbox3.Multiline = true;
            textbox3.Name = "textbox3";
            textbox3.Size = new Size(157, 28);
            textbox3.TabIndex = 7;
            textbox3.TextChanged += textbox3_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(574, 173);
            button3.Name = "button3";
            button3.Size = new Size(150, 31);
            button3.TabIndex = 12;
            button3.Text = "LogIn";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(280, 222);
            label7.Name = "label7";
            label7.Size = new Size(207, 28);
            label7.TabIndex = 13;
            label7.Text = "Forgot Password?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(107, 262);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 14;
            label8.Text = "Username:";
            // 
            // textbox5
            // 
            textbox5.Font = new Font("Microsoft Sans Serif", 12F);
            textbox5.Location = new Point(280, 262);
            textbox5.Multiline = true;
            textbox5.Name = "textbox5";
            textbox5.Size = new Size(210, 25);
            textbox5.TabIndex = 15;
            textbox5.TextChanged += textbox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(107, 299);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 16;
            label9.Text = "New Password:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cambria", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(107, 333);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 18;
            label10.Text = "Confirm Pssword:";
            // 
            // textbox6
            // 
            textbox6.Font = new Font("Microsoft Sans Serif", 12F);
            textbox6.Location = new Point(280, 299);
            textbox6.Multiline = true;
            textbox6.Name = "textbox6";
            textbox6.Size = new Size(210, 25);
            textbox6.TabIndex = 19;
            textbox6.TextChanged += textbox6_TextChanged;
            // 
            // textbox7
            // 
            textbox7.Font = new Font("Microsoft Sans Serif", 12F);
            textbox7.Location = new Point(280, 333);
            textbox7.Multiline = true;
            textbox7.Name = "textbox7";
            textbox7.Size = new Size(210, 25);
            textbox7.TabIndex = 20;
            textbox7.TextChanged += textbox7_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(311, 374);
            button1.Name = "button1";
            button1.Size = new Size(150, 31);
            button1.TabIndex = 21;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textbox7);
            Controls.Add(textbox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textbox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textbox4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textbox3);
            Controls.Add(label4);
            Controls.Add(textbox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textbox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textbox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox6;
        private System.Windows.Forms.TextBox textbox7;
        private System.Windows.Forms.Button button1;
    }
}