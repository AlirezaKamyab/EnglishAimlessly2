using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EnglishAimlessly2.Model
{
    public class GroupModel
    {
        public GroupModel() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("UserId"), NotNull]
        public int UserId { get; set; }
        [Column("Name"), MaxLength(128)]
        public string Name { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }
        [Column("UpdatedDate")]
        public DateTime UpdatedDate { get; set; }

        [SQLite.Ignore]
        public int Progress { get; set; } = 0;
    }
}
