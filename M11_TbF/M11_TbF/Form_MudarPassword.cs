﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_TbF
{
    public partial class Form_MudarPassword : Form
    {
        Utilizador User;
        private string Password;
        private string Username;
        public Form_MudarPassword(string username)
        {
            Username = username;
            InitializeComponent();
        }

        public Form_MudarPassword()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                User.Alterar_Password(Username, textBox1.Text);
            }

            else
            {
                MessageBox.Show("Password não é igual á 1ª tentativa");
                this.Hide();
                Form_MudarPassword FM = new Form_MudarPassword();
                FM.Show();

            }
        }

        private void Form_MudarPassword_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}