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
        Utilizador User = new Utilizador();

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
                        try
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
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
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
            frm.MudarUserControl(new UserControlLogin(frm));
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }

        private void UserControlSignUP_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Username.Text.Length >= 3 && textBox_Username.Text.Length <= 10 && textBox_Password.Text.Length >= 3 && textBox_Password.Text.Length <= 10)
            {
                label_UserPass.ForeColor = Color.Green;
            }
            else
            {
                label_UserPass.ForeColor = Color.Red;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Username.Text.Length >= 3 && textBox_Username.Text.Length <= 10 && textBox_Password.Text.Length >= 3 && textBox_Password.Text.Length <= 10)
            {
                label_UserPass.ForeColor = Color.Green;
            }
            else
            {
                label_UserPass.ForeColor = Color.Red;
            }

            if (textBox_Password.Text == textBox_ConfPassword.Text)
            {
                label_passcoincide.ForeColor = Color.Green;
            }
            else
            {
                label_passcoincide.ForeColor = Color.Red;
            }
        }

        private void textBox_ConfPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text == textBox_ConfPassword.Text)
            {
                label_passcoincide.ForeColor = Color.Green;
            }
            else
            {
                label_passcoincide.ForeColor = Color.Red;
            }
        }
    }
}
