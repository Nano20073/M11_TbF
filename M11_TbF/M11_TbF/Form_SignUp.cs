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
    public partial class Form_SignUp : Form
    {
        Utilizador User;
        string Username, Password;

        private Image defaultBackground;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            User.Criar_Utilizador(textBox1.Text, textBox2.Text);
            MessageBox.Show("A conta foi criada. Reinicie o Jogo para fazer login.");
            this.Close();
            Form_Login FL = new Form_Login();
            FL.Show();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
    }
}
