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
        Utilizador User;
        Background BG;
        string Username, Password;
        private Image defaultBackground;

        public Form_Login()
        {
            InitializeComponent();
            
        }

        private void button_Logar_Click(object sender, EventArgs e)
        {
            Username = textBox_UserName.ToString().Substring(36,textBox_UserName.TextLength);
            Password = textBox_PassWord.ToString().Substring(36, textBox_PassWord.TextLength);
            User.Utilizador_login(Username, Password);
            if(User.Utilizador_login_get() == "")
            {
                MessageBox.Show("Erro de Login");
            }
            else
            {
                this.Hide();
                Form_Menu_Principal F2 = new Form_Menu_Principal(Username);
                
                F2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox_PassWord_TextChanged(object sender, EventArgs e)
        {
            // Create an instance of the TextBox control.
           // textBox_PassWord textBox1 = new textBox_PassWord();
            // Set the maximum length of text in the control to eight.
           // textBox1.MaxLength = 8;
            // Assign the asterisk to be the password character.
            // textBox1.PasswordChar = '*';
            // Change all text entered to be lowercase.
           // textBox1.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
           // textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button_Logar_MouseEnter(object sender, EventArgs e)
        {
            this.button_Logar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botão_login);
        }

        private void button_Logar_MouseLeave(object sender, EventArgs e)
        {
            this.button_Logar.BackgroundImage = defaultBackground;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SignUp FS = new Form_SignUp();
            FS.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User = new Utilizador();
            BG = new Background();
            string strPath = Application.StartupPath + "\\images\\";

            this.BackgroundImage = Image.FromFile(strPath + "IMG" + BG.BG_Get().ToString() + ".jpg");
        }
    }
}
