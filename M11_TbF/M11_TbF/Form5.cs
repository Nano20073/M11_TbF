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
    public partial class Form5 : Form
    {
        Perguntas Per;
        Background BG;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");


            Per = new Perguntas();
            label_nivel.Text = Per.Nivel_Get().ToString();
            Per.Pergunta_Set();
            label_pergunta.Text = Per.Pergunta_Get();
            radioButton_r1.Text = Per.Resposta1_Get();
            radioButton_r2.Text = Per.Resposta2_Get();
            radioButton_r3.Text = Per.Resposta3_Get();
            radioButton_r4.Text = Per.Resposta4_Get();
            
        }

        private void button_submeter_Click(object sender, EventArgs e)
        {
            if (radioButton_r1.Checked == true)
            {
                Per.Pergunta_Verificar(radioButton_r1.Text);
            }

            if (radioButton_r2.Checked == true)
            {
                Per.Pergunta_Verificar(radioButton_r2.Text);
            }

            if (radioButton_r3.Checked == true)
            {
                Per.Pergunta_Verificar(radioButton_r3.Text);
            }

            if (radioButton_r4.Checked == true)
            {
                if (Per.Pergunta_Verificar(radioButton_r4.Text) == true)
                {

                }
            }
        }
    }
}
