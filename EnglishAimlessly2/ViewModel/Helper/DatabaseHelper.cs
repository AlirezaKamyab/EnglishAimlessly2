using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class DatabaseHelper
    {
        public static string DATABASE_PATH { get; set; } = Path.Combine(Environment.CurrentDirectory, "Database.db");
    }
}
