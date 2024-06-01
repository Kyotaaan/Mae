namespace Tic_Tac_Toe
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
            tbt1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            reset = new Button();
            NG = new Button();
            po_score = new TextBox();
            px_score = new TextBox();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // tbt1
            // 
            tbt1.BackColor = Color.DeepPink;
            tbt1.BorderStyle = BorderStyle.None;
            tbt1.Font = new Font("Cambria", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbt1.ForeColor = Color.LightPink;
            tbt1.Location = new Point(222, 11);
            tbt1.Margin = new Padding(3, 2, 3, 2);
            tbt1.Multiline = true;
            tbt1.Name = "tbt1";
            tbt1.ReadOnly = true;
            tbt1.Size = new Size(469, 79);
            tbt1.TabIndex = 0;
            tbt1.Text = "TIC - TAC - TOE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightPink;
            label1.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(606, 101);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 13;
            label1.Text = "PLAYER X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightPink;
            label2.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 148);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 14;
            label2.Text = "PLAYER O:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(50, 94);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(134, 110);
            button1.TabIndex = 17;
            button1.Tag = "0";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Pink;
            button2.Location = new Point(210, 94);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(134, 110);
            button2.TabIndex = 18;
            button2.Tag = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Pink;
            button3.Location = new Point(369, 94);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(134, 110);
            button3.TabIndex = 19;
            button3.Tag = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightPink;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Pink;
            button6.Location = new Point(369, 221);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(134, 110);
            button6.TabIndex = 22;
            button6.Tag = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightPink;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Pink;
            button5.Location = new Point(210, 221);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(134, 110);
            button5.TabIndex = 21;
            button5.Tag = "4";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Pink;
            button4.Location = new Point(50, 221);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(134, 110);
            button4.TabIndex = 20;
            button4.Tag = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LightPink;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Pink;
            button9.Location = new Point(369, 349);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(134, 110);
            button9.TabIndex = 25;
            button9.Tag = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LightPink;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Pink;
            button8.Location = new Point(210, 349);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(134, 110);
            button8.TabIndex = 24;
            button8.Tag = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightPink;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Cambria", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Pink;
            button7.Location = new Point(50, 349);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(134, 110);
            button7.TabIndex = 23;
            button7.Tag = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // reset
            // 
            reset.BackColor = Color.LightPink;
            reset.FlatStyle = FlatStyle.Flat;
            reset.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            reset.Location = new Point(613, 299);
            reset.Margin = new Padding(3, 2, 3, 2);
            reset.Name = "reset";
            reset.Size = new Size(154, 35);
            reset.TabIndex = 26;
            reset.Text = "RESET";
            reset.UseVisualStyleBackColor = false;
            reset.Click += button10_Click;
            // 
            // NG
            // 
            NG.BackColor = Color.LightPink;
            NG.FlatStyle = FlatStyle.Flat;
            NG.Font = new Font("Cambria", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NG.Location = new Point(613, 352);
            NG.Margin = new Padding(3, 2, 3, 2);
            NG.Name = "NG";
            NG.Size = new Size(154, 37);
            NG.TabIndex = 27;
            NG.Text = "EXIT";
            NG.UseVisualStyleBackColor = false;
            NG.Click += NG_Click;
            // 
            // po_score
            // 
            po_score.Enabled = false;
            po_score.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            po_score.Location = new Point(762, 155);
            po_score.Margin = new Padding(3, 2, 3, 2);
            po_score.Multiline = true;
            po_score.Name = "po_score";
            po_score.Size = new Size(62, 28);
            po_score.TabIndex = 30;
            po_score.Text = "0";
            // 
            // px_score
            // 
            px_score.Enabled = false;
            px_score.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            px_score.Location = new Point(762, 101);
            px_score.Margin = new Padding(3, 2, 3, 2);
            px_score.Multiline = true;
            px_score.Name = "px_score";
            px_score.Size = new Size(62, 28);
            px_score.TabIndex = 29;
            px_score.Text = "0";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Cambria", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.Purple;
            lbl3.Location = new Point(546, 207);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(0, 41);
            lbl3.TabIndex = 31;
            lbl3.Click += lbl3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(846, 509);
            Controls.Add(lbl3);
            Controls.Add(po_score);
            Controls.Add(px_score);
            Controls.Add(NG);
            Controls.Add(reset);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbt1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbt1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button reset;
        private Button NG;
        protected internal TextBox po_score;
        private TextBox px_score;
        private Label lbl3;
    }
}
