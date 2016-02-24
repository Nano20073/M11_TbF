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
    class Utilizadores
    {
        private string Username_atual;
        public void Utilizadore_set(string Username, string Password)
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

                MessageBox.Show("\n{0}: Fetch the actual data: ");
                int row = 0;
                while (dr.Read())
                {

                    MessageBox.Show(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString());
                    if (dr.GetValue(0).ToString() == Username)
                    {
                        if (dr.GetValue(1).ToString() == Password)
                        {
                            Username_atual = Username;
                            MessageBox.Show("conetou-se");
                            //abrir form2
                            /*Form1 F1 = new Form1();
                            F1.Hide();
                            Form2 F2 = new Form2();
                            F2.Show();*/
                            break;
                        }
                    }
                    row++;
                }
                MessageBox.Show("Total Row Count: {1}" + row.ToString());
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
                MessageBox.Show("{0}: Cleanup. Done.");
            }
        }
    }
}
