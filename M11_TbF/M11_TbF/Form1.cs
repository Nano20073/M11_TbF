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
    public partial class Form1 : Form
    {
        Utilizadores User;
        string Username, Password;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            Username = textBox_UserName.ToString().Substring(36,textBox_UserName.TextLength);
            Password = textBox_PassWord.ToString().Substring(36, textBox_PassWord.TextLength);
            User.Utilizador_set(Username, Password);
            if(User.Utilizador_get() == "")
            {
                MessageBox.Show("Erro de Login");
            }
            else
            {
                this.Hide();
                Form2 F2 = new Form2();
                F2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User = new Utilizadores();
        }
    }
}
