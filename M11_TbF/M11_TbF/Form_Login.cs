using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace M11_TbF
{
    public partial class Form_Login : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username, Password;

        public Form_Login()
        {
            InitializeComponent();
            
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            textBox_UserName.Select();
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            Username = textBox_UserName.ToString().Substring(36, textBox_UserName.TextLength);
            Password = textBox_PassWord.ToString().Substring(36, textBox_PassWord.TextLength);
            User.Utilizador_login(Username, Password);
            if (User.Utilizador_login_get() == "")
            {
                MessageBox.Show("Erro de Login");
            }
            else
            {
                this.Hide();
                Form_Menu_Principal F2 = new Form_Menu_Principal(Username, Password);

                F2.Show();
            }
        }

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SignUp FS = new Form_SignUp();
            FS.Show();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Drag_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_Drag_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
