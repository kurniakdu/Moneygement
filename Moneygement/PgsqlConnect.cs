using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class PgsqlConnect
    {
        public NpgsqlConnection conn;
        public NpgsqlCommand cmd;
        public string connstring = "Host=localhost;Port=5432;Username=postgres;Password=root;Database=db_moneygement";
        public string sql = null;   
    }
}
