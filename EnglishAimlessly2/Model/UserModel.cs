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
        public UserModel(string name, string email, string username)
        {
            Name = name;
            Email = email;
            Username = username;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("Name"), MaxLength(128)]
        public string Name { get; set; }
        [Column("Username")]
        public string Username { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedAccountDate { get; set; }
    }
}
