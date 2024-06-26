﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ah
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdminUser.Text))
            {
                MessageBox.Show("Admin name cannot be empty, try again!", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {

                MessageBox.Show("Welcome!", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            AdminUser.Text = "";
        }

        private void AdminUser_TextChanged(object sender, EventArgs e)
        {
            AdminUser.PasswordChar = '*';
        }
    }
}