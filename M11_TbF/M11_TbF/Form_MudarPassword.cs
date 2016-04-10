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
        Form Owner;
        private string pass;
        private string Username;
        public Form_MudarPassword(string username, string password, Form f)
        {
            Username = username;
            InitializeComponent();
        }

        public Form_MudarPassword()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text && textBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer mudar a sua password? \n Se clicar sim a aplicação irá fechar ", "Password", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    User.Alterar_Password(Username, textBox1.Text);
                    Application.Exit();
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                
            }

            else
            {
                MessageBox.Show("As passwords não coinncidem.");

            }
        }

        private void Form_MudarPassword_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}
