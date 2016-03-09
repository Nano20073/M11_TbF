using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                User.Alterar_Password(Username, textBox1.Text);
            }
        }

        private void Form_MudarPassword_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}
