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
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");
            
            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Utilizadores ([Nome],[PassWord]) values (?,?)";
            cmd.Parameters.AddWithValue("@Nome", Username);
            cmd.Parameters.AddWithValue("@PassWord", Password);
            cmd.Connection = cn;

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("{Successfully connected to database. Data source name:" + cn.DataSource);
                //MessageBox.Show("SQL query:\n {0}" + query);

                //MessageBox.Show("\n{0}: Fetch the actual data: ");

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
                //MessageBox.Show("{0}: Cleanup. Done.");
            }
        }
        //
        //
        //
        //
        //
        public void Utilizador_login(string Username, string Password)
        {
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();
                //MessageBox.Show("{Successfully connected to database. Data source name:" + cn.DataSource);
                //MessageBox.Show("SQL query:\n {0}" + query);

                // Run the query and create a record set
                OleDbDataReader dr = cmd.ExecuteReader();

                //MessageBox.Show("\n{0}: Fetch the actual data: ");
                while (dr.Read())
                {

                    //MessageBox.Show(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString());
                    if (dr.GetValue(0).ToString() == Username)
                    {
                        if (dr.GetValue(1).ToString() == Password)
                        {
                            Username_login = Username;
                            //MessageBox.Show("conetou-se");
                            //abrir form2
                            
                        }
                    }
                }
                //MessageBox.Show("Total Row Count: {1}" + row.ToString());
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
                //MessageBox.Show("{0}: Cleanup. Done.");
            }
        }
        //
        //
        //
        //
        //
        public void Alterar_Nome_de_Utilizador(string Username, string Novo_Username)
        {
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                //  new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\\M11_TbF_DB.accdb;Jet OLEDB:Database");
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();

                // Run the query and create a record set


                //MessageBox.Show("\n{0}: Fetch the actual data: ");

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
                //MessageBox.Show("{0}: Cleanup. Done.");
            }
        }
        //
        //
        //
        //
        //
        public void Adicionar_Estatisticas(int nivel_maximo)
            {
            // Connection string for ADO.NET via OleDB
            OleDbConnection cn =
                new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = M11_TbF_DB.accdb; Persist Security Info=False;");

            // Prepare SQL query
            string query = "SELECT Utilizadores.Nome, Utilizadores.PassWord FROM Utilizadores; ";
            OleDbCommand cmd = new OleDbCommand(query, cn);

            try
            {
                cn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Utilizadores SET Nivel_Maximo = @Nivel_Maximo WHERE @Nivel_Maximo > Nivel_Maximo;";
                cmd.Parameters.AddWithValue("@Nivel_Maximo", nivel_maximo);

                cmd.Parameters.AddWithValue("@Old_Nome", );
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
        public string Utilizador_login_get()
        {
            return Username_login;
        }




    }
}
