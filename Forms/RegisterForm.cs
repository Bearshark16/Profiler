﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profiler
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public static string username;
        public static string password;

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;

            if (!ConfirmPassTextBox.Text.Equals(PasswordTextBox.Text))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;
        }

        #region Bullshit
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
