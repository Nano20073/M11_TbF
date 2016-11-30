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
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        Utilizador User;
        string Username_Atual;
        Form Owner;

        public Form_Estatisticas(string Username, Form f)
        {
            Owner = f;
            Username_Atual = Username;
            InitializeComponent();
        }

        private void Form_Estatisticas_Load(object sender, EventArgs e)
        {
            Connections.con.Open();
            label_utilizador.Select();
            User = new Utilizador();
            label_NivelMaximo.Text = "Nivel Máximo Atigindo:\n"+User.get_nivel_maximo(Username_Atual);
            label_utilizador.Text = Username_Atual;
            label_TotaldeDinheiroGanho.Text = "Dinheiro total ganho:\n"+User.GetTotalGanho(Username_Atual).ToString() + " $";
            Connections.con.Close();
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

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            Owner.Close();
            this.Close();
            Form_Login FLOGIN = new Form_Login();
            FLOGIN.Show();
        }
    }
}
