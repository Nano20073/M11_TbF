using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace M11_TbF
{
    class Utilizador
    {
        private string Username_login="";



        public void Criar_Utilizador(string Username, string Password)
        {
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");
            
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Utilizadores ([Nome],[PassWord],[Nivel_Maximo]) values (?,?,?)";
            cmd.Parameters.AddWithValue("@Nome", Username);
            cmd.Parameters.AddWithValue("@PassWord", Password);
            cmd.Parameters.AddWithValue("@Nivel_Maximo", 0);
            cmd.Connection = cn;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
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
        public void Utilizador_login(string Username, string Password)
        {
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr.GetValue(0).ToString() == Username)
                    {
                        if (dr.GetValue(1).ToString() == Password)
                        {
                            Username_login = Username;
                            
                        }
                    }
                }
                dr.Close();
            }


            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
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
        public void Alterar_Nome_de_Utilizador(string Username, string Novo_Username)
        {
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nome = @Nome WHERE Nome = @Old_Nome;";
                cmd.Parameters.AddWithValue("@Nome", Novo_Username);
                cmd.Parameters.AddWithValue("@Old_Nome", Username);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }


            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
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
        public void Atualizar_Estatisticas(int nivel_maximo, string Username_atual)
            {
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            string query = "SELECT Utilizadores.Nome, Utilizadores.Nivel_Maximo FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();

               
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nivel_Maximo = @Nivel_Maximo WHERE Nome = @Nome AND @Nivel_Maximo > Nivel_Maximo;";
                cmd.Parameters.AddWithValue("@Nivel_Maximo", nivel_maximo);
                cmd.Parameters.AddWithValue("@NNome", Username_atual);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }

            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
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
        /*public string get_nivel_maximo(string Username)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            string query = "SELECT Utilizadores.Nome, Utilizadores.Nivel_Maximo FROM Utilizadores WHERE (((Utilizadores.Nome)=" + Nivel_da_Pergunta.ToString() + "));";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {

                cn.Open();

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() == NPergunta.ToString())
                    {
                        
                    }

                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("{0}: OleDbException: Unable to connect or retrieve data from data source: {1}.",
                     ex.ToString());
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
        }*/
        public string Utilizador_login_get()
        {
            return Username_login;
        }




    }
}
