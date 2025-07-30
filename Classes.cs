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
        // pc
        public static string ConnectionString = "Data Source=DESKTOP-MQH085R\\SQLEXPRESS01;Initial Catalog=SIS1;Integrated Security=True;TrustServerCertificate=True";
       //lab
       // public static string ConnectionString = "Data Source=LAB4-PC42\\LAB2PC45;Initial Catalog=SIS1;Integrated Security=True;TrustServerCertificate=True";
    }
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }
    }
}
