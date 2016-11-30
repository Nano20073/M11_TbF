using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace M11_TbF
{
    class Utilizador
    {
        MySqlConnection con = new MySqlConnection("Server=fernandosilva.ddns.net; Database=movedb; Uid=Nano; Pwd=naointressa;");
        private string Username_login="";
        private int ID_Utilizador;


        public void Criar_Utilizador(string Username, string Password)
        {
            

            MySqlCommand comd = new MySqlCommand();

            comd.CommandType = CommandType.Text;
            comd.CommandText = "insert into Utilizadores (Nome,PassWord,Nivel_Maximo,Total_Ganho) values (?,?,?,?)";
            comd.Parameters.AddWithValue("@Nome", Username);
            comd.Parameters.AddWithValue("@PassWord", Password);
            comd.Parameters.AddWithValue("@Nivel_Maximo", 0);
            comd.Parameters.AddWithValue("@Total_Ganho", 0);
            comd.Connection = con;

            try
            {
                con.Open();
                comd.ExecuteNonQuery();
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
        //
        //
        //
        //
        //
        public bool Utilizador_Existe(string Username)
        {
            string query = "SELECT Nome FROM Utilizadores; ";
            MySqlCommand comd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader dr = comd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr.GetValue(0).ToString() == Username)
                    {
                        return true;
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        //
        //
        //
        //
        //
        public void Utilizador_login(string Username, string Password)
        {
            string query = "SELECT ID_Utilizador, Nome, PassWord FROM Utilizadores; ";
            MySqlCommand comd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader dr = comd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr.GetValue(1).ToString() == Username)
                    {
                        if (dr.GetValue(2).ToString() == Password)
                        {
                            Username_login = Username;
                            ID_Utilizador = int.Parse(dr.GetValue(0).ToString());
                        }
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        //
        //
        //
        //
        //
        public void Alterar_Nome_de_Utilizador(string Username, string Novo_Username)
        {
            

            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nome = @Nome WHERE Nome = @Old_Nome;";
                cmd.Parameters.AddWithValue("@Nome", Novo_Username);
                cmd.Parameters.AddWithValue("@Old_Nome", Username);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        //
        //
        //
        //
        //
        public void Alterar_Password(string username, string Nova_Password)
        {

            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET PassWord = @Password WHERE Nome = @Username;";
                cmd.Parameters.AddWithValue("@Password", Nova_Password);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        //
        //
        //
        //
        //
        public void Atualizar_Estatisticas(int nivel_maximo, string Username_atual)
            {
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            OleDbCommand cmd = new OleDbCommand();

            try
            {
                cn.Open();

               
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nivel_Maximo = @Nivel_Maximo WHERE Nome = @Nome AND @Nivel_Maximo > Nivel_Maximo;";
                cmd.Parameters.AddWithValue("@Nivel_Maximo", nivel_maximo-1);
                cmd.Parameters.AddWithValue("@Nome", Username_atual);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                cn.Close();
            }
        }
        //
        //
        //
        //
        //
        public int get_nivel_maximo(string Username)
        {
            string query = "SELECT Nome, Nivel_Maximo FROM Utilizadores;";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(dr.GetValue(0).ToString() == Username) { return int.Parse(dr.GetValue(1).ToString()); }
                }
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
        //
        //
        //
        //
        //
        public string Utilizador_login_get()
        {
            return Username_login;
        }
        //
        //
        //
        //
        //
        public int ID_Utilizador_get()
        {
            return ID_Utilizador;
        }
        //
        //
        //
        //
        //
        public int GetTotalGanho(string Username)
        {
            
            //////////////// Encontra qual o valor masximo antigo \\\\\\\\\\\\\\\\\\\\
            

            string query = "SELECT Nome, Total_Ganho FROM Utilizadores WHERE Nome ='" + Username + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    return int.Parse(dr.GetValue(1).ToString());
                }
                 
                dr.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
        //
        //
        //
        //
        //
        public int GetTotalGanhoCONTA(int Valor_a_Adicionar, string Username)
        {
            int Valor_Maximo;
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            int Valor_Total_Anterior;


            string query = "SELECT Nome, Total_Ganho FROM Utilizadores WHERE Nome ='" + Username + "';";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    Valor_Total_Anterior = int.Parse(dr.GetValue(1).ToString());
                    Valor_Maximo = Valor_Total_Anterior + Valor_a_Adicionar;
                    return Valor_Maximo;
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                cn.Close();
            }
            return 0;
        }
        //
        //
        //
        //
        //
        public void AdicionarTotalGanho(int Valor_a_Adicionar, string Username)
        {
            
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");


            try { 

                OleDbCommand cmmd = new OleDbCommand();

                cn.Open();
                cmmd.CommandType = CommandType.Text;
                cmmd.CommandText = "UPDATE Utilizadores SET Total_Ganho = @Total_Ganho WHERE Nome=@Username;";
                cmmd.Parameters.AddWithValue("@Total_Ganho", GetTotalGanhoCONTA(Valor_a_Adicionar, Username));
                cmmd.Parameters.AddWithValue("@Username", Username);
                cmmd.Connection = cn;
                cmmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                cn.Close();
            }           
        }
        //
        //
        //
        //
        //
        public void Reset(string username)
        {

            MySqlCommand cmd = new MySqlCommand();

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Total_Ganho = 0, Nivel_Maximo = 0 WHERE Nome=@Username;";
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("{0}: Exception: Unable to connect or retrieve data from data source: .",
                     ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
