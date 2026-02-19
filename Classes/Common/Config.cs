using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pr29.Classes.Common
{
    public class Config
    {
        public static string ConnectionConfig = "server=127.0.0.1; port=3306; user=root; pwt=; database=pcClub";
        public static MySqlServerVersion Version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
