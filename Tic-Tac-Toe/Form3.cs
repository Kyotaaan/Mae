using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tic_Tac_Toe
{
    public partial class Form3 : Form
    {
        private List<User> users = new List<User>();

        public Form3()
        {

            InitializeComponent();
        }

        

        private void textbox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {
            textbox2.PasswordChar = '*';
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string username = textbox1.Text;
            string password = textbox2.Text;

            if (string.IsNullOrEmpty(textbox1.Text))
            {
                MessageBox.Show("Username cannot be empty", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else if (string.IsNullOrEmpty(textbox2.Text))
            {
                MessageBox.Show("Password cannot be empty, try again!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else
            {
                if (users.Any(user => user.GetUsername() == username))
                {
                    MessageBox.Show("Player name already exist!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                users.Add(new Player(username, password));

                MessageBox.Show("Player created!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {
            textbox4.PasswordChar = '*';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textbox3.Text;
            string password = textbox4.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty, try again!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty, try again!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (IsExistingPlayer(username, password))
            {
                MessageBox.Show("Log-in Successful", "Player", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password, please try again!", "Player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void textbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox6_TextChanged(object sender, EventArgs e)
        {
            textbox6.PasswordChar = '*';

        }

        private void textbox7_TextChanged(object sender, EventArgs e)
        {
            textbox7.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textbox5.Text;
            string newPassword = textbox6.Text;
            string confirmPassword = textbox7.Text;

            // Check if username or new password are empty
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty, try again!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New password cannot be empty, try again!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password does not match with confirm password, try again!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = users.FirstOrDefault(u => u.GetUsername() == username);
            if (user == null)
            {
                MessageBox.Show("Username does not exist, please enter an existing username!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user.UpdatePassword(newPassword);

            MessageBox.Show("Password updated successfully!", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public abstract class User
        {
            protected string username;
            protected string password;

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

            public string GetUsername()
            {
                return username;
            }

            public bool VerifyLogin(string username, string password)
            {
                return this.username == username && this.password == password;
            }

            public abstract void UpdatePassword(string newPassword);
        }

        public class Player : User
        {
            public Player(string username, string password) : base(username, password)
            {

            }

            public override void UpdatePassword(string newPassword)
            {
                this.password = newPassword;
            }
        }

        public class Administrator : User
        {
            private string adminName;

            public Administrator(string adminName, string username, string password) : base(username, password)
            {
                this.adminName = adminName;
            }

            public void UpdateAdminName(string adminName)
            {
                this.adminName = adminName;
            }

            public override void UpdatePassword(string newPassword)
            {
                this.password = newPassword;
            }
        }

        private bool IsExistingPlayer(string username, string password)
        {
            return users.Any(user => user.VerifyLogin(username, password));
        }
    }
}