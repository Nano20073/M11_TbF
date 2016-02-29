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
        
        public Form6()
        {
            InitializeComponent();
        }

        private void button_mudar_IMG1_Click(object sender, EventArgs e)
        {
            imagem = 6;
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + imagem + ".jpg"); // 1.jpg Image file name

            
        }

        private void button_mudar_IMG2_Click(object sender, EventArgs e)
        {
            imagem = 3;
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + imagem + ".jpg"); // 1.jpg Image file name

        }
    }
}
