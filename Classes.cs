using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Classes
    {
    }
    public static class DatabaseConfig
    {
        public static string ConnectionString = "Data Source=desktop-mqh085r\\sqlexpress01;Initial Catalog=SIS1;Integrated Security=True;TrustServerCertificate=True";
    }
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }
    }
}
