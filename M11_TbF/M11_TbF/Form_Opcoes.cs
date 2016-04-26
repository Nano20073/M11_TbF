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
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        Conquista Conq;
        Form Owner;
        string Username_Atual;
        string password;
        int ID_Utilizador;
        public Form_Opcoes(string Username, string pass, Form f, int ID_User)
        {
            ID_Utilizador = ID_User;
            Username_Atual = Username;
            password = pass;
            Owner = f;
            InitializeComponent();
        }

        private void Form_Opcoes_Load(object sender, EventArgs e)
        {
            label_OPCOES.Select();
            panel_layout.VerticalScroll.Value = 0;
            panel_layout.HorizontalScroll.Maximum = 0;
            panel_layout.VerticalScroll.Maximum = 0;
            panel_layout.AutoScroll = false;           
            panel_layout.VerticalScroll.Visible = false;
            panel_layout.HorizontalScroll.Visible = false;
            panel_layout.AutoScroll = true;
            
            label_utilizador.Text = Username_Atual;
            User = new Utilizador();
            Conq = new Conquista();
        }

        private void button_AlterarUsername_Click(object sender, EventArgs e)
        {
            if(textBox_NovoUtilizador.Text.Length >=3 && textBox_NovoUtilizador.Text.Length <= 10)
            {
                if (textBox_NovoUtilizador.Text == textBox_ConfirmarNovoUsername.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer mudar o seu Username? \n Se clicar sim a aplicação irá fechar ", "username", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        User.Alterar_Nome_de_Utilizador(Username_Atual, textBox_NovoUtilizador.Text);
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No) { }
                }
                else
                {
                    MessageBox.Show("Os Usernames não coincidem.");
                }
            }
            else
            {
                MessageBox.Show("O seu Username não tem o requesito.");
            }
            
        }

        private void button_AlterarPassword_Click(object sender, EventArgs e)
        {
            if (textBox_NovaPassword.Text.Length >= 3 && textBox_NovaPassword.Text.Length <= 10)
            {
                if (textBox_NovaPassword.Text == textBox_ConfirmarNovaPassword.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer mudar a sua password? \n Se clicar sim a aplicação irá fechar ", "Password", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        User.Alterar_Password(Username_Atual, textBox_NovaPassword.Text);
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No) { }
                }
                else
                {
                    MessageBox.Show("As passwords não coinncidem.");
                }
            }
            else
            {
                MessageBox.Show("A sua password não tem o requesito.");
            }
                
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer reset? \n Se clicar sim a aplicação irá fechar ", "Reset", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                User.Reset(Username_Atual);
                Conq.Reset_Conquistas(ID_Utilizador);
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No){}
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void panel_Drag_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_Drag_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_MiniSair_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_MiniSair_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel_MiniSair_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void label_lgout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login F1 = new Form_Login();
            F1.Show();
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
