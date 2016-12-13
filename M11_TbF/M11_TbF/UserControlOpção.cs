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
    public partial class UserControlOpção : UserControl
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        Conquista Conq;
        System.Windows.Forms.Form Owner;
        string Username_Atual;
        string password;
        int ID_Utilizador;
        Form frm;

        public UserControlOpção(string Username, string pass, Form Frm, int ID_User)
        {
            InitializeComponent();
            ID_Utilizador = ID_User;
            password = pass ;
            Username_Atual = Username;
            frm = Frm;
        }

        private void label_lgout_Click(object sender, EventArgs e)
        {
            frm.Close();
            Form F1 = new Form();
            F1.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_AlterarUsername_Click(object sender, EventArgs e)
        {
            if (textBox_NovoUtilizador.Text.Length >= 3 && textBox_NovoUtilizador.Text.Length <= 10)
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
            else if (dialogResult == DialogResult.No) { }
        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            frm.Close();
            Form FM = new Form();
            FM.Show();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
    }
}
