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
    public partial class Form2 : Form
    {
        Utilizadores User;
        Background BG;
        private Image defaultBackground;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            User = new Utilizadores();
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
            label_utilizador.Text = User.Utilizador_get();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.IMG1);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = defaultBackground;
        }
    }
}
