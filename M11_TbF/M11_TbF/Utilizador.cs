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

            OleDbCommand cmd = new OleDbCommand();

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

            OleDbCommand cmd = new OleDbCommand();

            try
            {
                cn.Open();

               
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nivel_Maximo = @Nivel_Maximo WHERE Nome = @Nome AND @Nivel_Maximo > Nivel_Maximo;";
                cmd.Parameters.AddWithValue("@Nivel_Maximo", nivel_maximo);
                cmd.Parameters.AddWithValue("@Nome", Username_atual);
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
        public string get_nivel_maximo(string Username)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            string query = "SELECT Utilizadores.Nome, Utilizadores.Nivel_Maximo FROM Utilizadores;";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {

                cn.Open();

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(dr.GetValue(0).ToString() == Username) { return dr.GetValue(1).ToString(); }
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
            return "";
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
        public void Alterar_Password(string username, string Nova_Password)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            //string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand();

            try
            {
                cn.Open();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "UPDATE Utilizadores SET PassWord = @Password WHERE Nome = @Username;";
                cmd.CommandText = "UPDATE Utilizadores SET Utilizadores.[PassWord] = @Password WHERE (((Utilizadores.[Nome])=[@Username]));";
                cmd.Parameters.AddWithValue("@Password", Nova_Password);
                cmd.Parameters.AddWithValue("@Username", username);               
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
        public int GetTotalGanho(int Valor_a_Adicionar, string Username)
        {
            int Valor_Maximo;
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            //////////////// Encontra qual o valor masximo antigo \\\\\\\\\\\\\\\\\\\\
            int Valor_Total_Anterior;
            

            string query = "SELECT Utilizadores.Nome, Utilizadores.Total_Ganho FROM Utilizadores WHERE Utilizadores.Nome ='" + Username + "';";
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
                //////////////// Adiciona ao valor antigo o dinheiro ganho \\\\\\\\\\\\\\\\\\\\



                OleDbCommand cmmd = new OleDbCommand();

                cn.Open();
                cmmd.CommandType = CommandType.Text;
                cmmd.CommandText = "UPDATE Utilizadores SET Total_Ganho = @Total_Ganho WHERE Nome = @Nome;";
                cmmd.Parameters.AddWithValue("@Nome", Username);
                cmmd.Parameters.AddWithValue("@Total_Ganho", GetTotalGanho(Valor_a_Adicionar, Username));
                cmmd.Connection = cn;
                cmmd.ExecuteNonQuery();

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
        public void Reset(string username)
        {
            OleDbConnection cn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            //string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand();

            try
            {
                cn.Open();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "UPDATE Utilizadores SET PassWord = @Password WHERE Nome = @Username;";
                cmd.CommandText = "UPDATE Utilizadores SET Utilizadores.[Total_Ganho], Utilizadores.[Nivel_Maximo] = @Nivel_Maximo WHERE (((Utilizadores.[Nome])=[@Username]));";
                cmd.Parameters.AddWithValue("@Total_Ganho",0);
                cmd.Parameters.AddWithValue("@Nivel_Maximo", 0);
                cmd.Parameters.AddWithValue("@Username", username);
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
    }
}
