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
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            textBox_Username.Select();
            User = new Utilizador();
        }

        private void button_criar_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text.Length >= 3 && textBox_Username.Text.Length <= 10)
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
                            this.Close();
                            Form_Login FL = new Form_Login();
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
                    MessageBox.Show("O sua Password não tem os requesitos.");
                }
            }
            else
            {
                MessageBox.Show("O seu Username não tem os requesitos.");
            }
        }

        private void label_entrar_login_Click(object sender, EventArgs e)
        {
            Form_Login FL = new Form_Login();
            FL.Show();
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
