using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite.Core;

namespace Pomegranate
{
    public class DatabaseManager
    {
        public void Show()
        {
            try
            {
                using (var connection = new SqliteConnection("Data Source=dataBase.db"))
                {
                    connection.Open();
                }

            }
            catch (SqliteException ex) { throw new Exception("Ошибка при загрузке данных: " + ex.Message); }
        }
    }
}
