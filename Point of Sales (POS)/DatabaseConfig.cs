using System.Data;
using System.Data.OleDb;

namespace Point_of_Sales__POS_
{
    class DatabaseConfig
    {
        public OleDbConnection con = new OleDbConnection(@"Provider=MICROSOFT.ACE.OLEDB.12.0; Data Source=|DataDirectory|//Point of Sales.accdb");
        public OleDbCommand cmd;
        public OleDbDataReader reader;
        public OleDbDataReader read;
        public string query = "";
        DataTable dt = new DataTable();

    }
}
