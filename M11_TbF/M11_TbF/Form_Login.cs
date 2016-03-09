using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace M11_TbF
{
    public partial class Form_Login : Form
    {
        Utilizador User;
        string Username, Password;
        private Image defaultBackground;

        public Form_Login()
        {
            InitializeComponent();
            
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            Username = textBox_UserName.ToString().Substring(36,textBox_UserName.TextLength);
            Password = textBox_PassWord.ToString().Substring(36, textBox_PassWord.TextLength);
            User.Utilizador_login(Username, Password);
            if(User.Utilizador_login_get() == "")
            {
                MessageBox.Show("Erro de Login");
            }
            else
            {
                this.Hide();
                Form_Menu_Principal F2 = new Form_Menu_Principal(Username, Password);
                
                F2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_PassWord_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SignUp FS = new Form_SignUp();
            FS.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}
