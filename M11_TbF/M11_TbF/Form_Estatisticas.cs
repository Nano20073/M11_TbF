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
    public partial class Form_Estatisticas : Form
    {
        Background BG;
        public Form_Estatisticas()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form2 F2 = new Form2();
            F2.Show();*/
        }
    }
}
