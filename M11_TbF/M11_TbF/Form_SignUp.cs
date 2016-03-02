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
        Background BG;
        string Username, Password;

        private Image defaultBackground;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void button_criar_MouseEnter(object sender, EventArgs e)
        {
            this.button_criar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.IMG1);
        }

        private void button_criar_MouseLeave(object sender, EventArgs e)
        {
            this.button_criar.BackgroundImage = defaultBackground;
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            User.Criar_Utilizador(textBox1.Text, textBox2.Text);

            this.Hide();
            Form_Login FL = new Form_Login();
            FL.Show();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
        }
    }
}
