using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EnglishAimlessly2.Model
{
    public class UserModel
    {
        public UserModel() { }
        public UserModel(string name, string lastname, string email, DateTime birthday, string username, string password)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
            Birthday = birthday;
            Username = username;
            Password = password;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("Name"), MaxLength(128)]
        public string Name { get; set; }
        [Column("Lastname"), MaxLength(128)]
        public string Lastname { get; set; }
        [Column("Birthday")]
        public DateTime Birthday { get; set; }
        [Column("Username")]
        public string Username { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedAccountDate { get; set; }
    }
}
