using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace M11_TbF
{
    public partial class Form_gestao : Form
    {
        MySqlConnection con = Connections.con;
        Form owner;
        public Form_gestao(Form f)
        {
            owner = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_MudarUsername_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            owner.Show();
            this.Close();
           
        }

        private void button_Criar_Click(object sender, EventArgs e)
        {
            MySqlCommand comd = new MySqlCommand();
            string RC ="";
            comd.CommandType = CommandType.Text;
            comd.CommandText = "insert into Perguntas (Pergunta,Resposta1,Resposta2, Resposta3, Resposta4, Resposta_Correta, Nivel) values (?,?,?,?,?,?,?)";
            comd.Parameters.AddWithValue("@Pergunta", textBox_Pergunta.Text);
            comd.Parameters.AddWithValue("@Resposta1", textBox_R1.Text);
            comd.Parameters.AddWithValue("@Resposta2", textBox_R2.Text);
            comd.Parameters.AddWithValue("@Resposta3", textBox_R3.Text);
            comd.Parameters.AddWithValue("@Resposta4", textBox_R4.Text);


            switch (comboBox_RC.Text)
            {
                case "Resposta 1":
                    RC = textBox_R1.Text;
                    break;

                case "Resposta 2":
                    RC = textBox_R2.Text;
                    break;

                case "Resposta 3":
                    RC = textBox_R3.Text;
                    break;

                case "Resposta 4":
                    RC = textBox_R4.Text;
                    break;
            }
            comd.Parameters.AddWithValue("@Resposta_Correta", RC);
            comd.Parameters.AddWithValue("@Nivel", int.Parse(comboBox_N.Text));
            comd.Connection = con;

            try
            {
                con.Open();
                comd.ExecuteNonQuery();
                MessageBox.Show("Pergunta criada");
                owner.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
