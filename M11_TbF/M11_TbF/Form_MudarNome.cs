using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11_TbF
{
    public partial class Form_MudarNome : Form
    {
        Utilizador User;
        string Utilizador_Antigo;
        public Form_MudarNome(string Utilizador)
        {
            Utilizador_Antigo = Utilizador;
            InitializeComponent();
        }

        private void button_Alterar_Click(object sender, EventArgs e)
        {
            if (textBox_NovoUtilizador.Text == textBox_ConfirmarNovoUsername.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer mudar o seu Username? \n Se clicar sim a aplicação irá fechar ", "username", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    User.Alterar_Nome_de_Utilizador(Utilizador_Antigo, textBox_NovoUtilizador.Text);
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                
            }
        }

        private void Form_MudarNome_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }
    }
