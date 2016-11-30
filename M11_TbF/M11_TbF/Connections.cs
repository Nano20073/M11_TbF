using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace M11_TbF
{
    static class Connections
    {
        static public MySqlConnection con = new MySqlConnection("Server=fernandosilva.ddns.net; Database=movedb; Uid=Nano; Pwd=naointressa;");
    }
}
