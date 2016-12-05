using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_TbF
{
    public partial class UserControlSignUP : UserControl
    {
        Form frm;
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        public UserControlSignUP(Form Frm)
        {
            frm = Frm;
            InitializeComponent();

        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text.Length >= 3 && textBox_Username.Text.Length <= 10)
            {
                if (textBox_Password.Text.Length >= 3 && textBox_Password.Text.Length <= 10)
                {
                    if (textBox_Password.Text == textBox_ConfPassword.Text)
                    {
                        if (User.Utilizador_Existe(textBox_Username.Text) == true)
                        {
                            MessageBox.Show("Username já está a ser usado.");
                        }
                        else
                        {
                            User.Criar_Utilizador(textBox_Username.Text, textBox_Password.Text);
                            MessageBox.Show("A conta foi criada.");
                            frm.Close();
                            Form FL = new Form();
                            FL.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("As passwords não coincidem.");
                    }
                }
                else
                {
                    MessageBox.Show("O seu Username e/ou Password não tem os requesitos.");
                }
            }
            else
            {
                MessageBox.Show("O seu Username e/ou Password não tem os requesitos.");
            }
        }

        private void label_entrar_login_Click(object sender, EventArgs e)
        {
            Form FL = new Form();
            FL.Show();
            frm.Close();
        }
    }
}
