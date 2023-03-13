using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lsp
{
     class Utils
    {
        public static MySqlConnection connection = new MySqlConnection("Server=localhost;UserID=root;Password=;Database=winformsapp");
    }
}
