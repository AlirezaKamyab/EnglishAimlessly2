using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EnglishAimlessly2.Model
{
    public class HistoryModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("GroupId")]
        public int GroupId { get; set; }
        [Column("WordId")]
        public int WordId { get; set; }
        [Column("Word")]
        public string Word { get; set; } = "Word";
        [Column("WordType")]
        public string WordType { get; set; } = "Type";
        [Column("Example")]
        public string Example { get; set; }
        [Column("DifficultyLevel")]
        public int DifficultyLevel { get; set; }
        [Column("PracticedDate")]
        public DateTime PracticedDate { get; set; }
    }
}
