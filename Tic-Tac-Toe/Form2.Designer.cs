namespace Tic_Tac_Toe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            AdminUser = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(186, 49);
            label1.Name = "label1";
            label1.Size = new Size(377, 75);
            label1.TabIndex = 0;
            label1.Text = "TIC-TAC-TOE";
            // 
            // AdminUser
            // 
            AdminUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AdminUser.Location = new Point(358, 148);
            AdminUser.Multiline = true;
            AdminUser.Name = "AdminUser";
            AdminUser.Size = new Size(187, 37);
            AdminUser.TabIndex = 1;
            AdminUser.TextChanged += AdminUser_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(177, 148);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 2;
            label2.Text = "Admin User:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(476, 210);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 3;
            button2.Text = "ENTER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(777, 338);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(AdminUser);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AdminUser;
        private Label label2;
        private Button button2;
    }
}