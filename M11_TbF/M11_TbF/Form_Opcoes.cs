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
    public partial class Form_Opcoes : Form
    {
        Background BG;
        public Form_Opcoes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_MudarBG F6 = new Form_MudarBG();
            F6.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 F2 = new Form2();
            F2.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            /*this.Hide();            
            Form7 F7 = new Form7();
            F7.Show();*/
        }
    }
}
