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
    public partial class Form6 : Form
    {
        Background BG;

        public Form6()
        {
            InitializeComponent();
        }

        private void button_mudar_IMG1_Click(object sender, EventArgs e)
        {
            BG.BG_Set(6);
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg"); // 1.jpg Image file name

            
        }

        private void button_mudar_IMG2_Click(object sender, EventArgs e)
        {
            BG.BG_Set(3);
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg"); // 1.jpg Image file name

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.Show();
        }
    }
}
