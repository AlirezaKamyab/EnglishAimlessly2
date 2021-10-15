using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EnglishAimlessly2.Model
{
    public class WordModel
    {
        public WordModel() { }
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("GroupId")]
        public int GroupId { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("Name"), MaxLength(128)]
        public string Name { get; set; } = "";
        [Column("WordType"), MaxLength(128)]
        public string WordType { get; set; } = "noun";
        [Column("Equivalent"), MaxLength(128)]
        public string Equivalent { get; set; } = "";
        [Column("Description"), MaxLength(128)]
        public string Description { get; set; } = "";
        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }
        [Column("UpdatedDate")]
        public DateTime UpdatedDate { get; set; }
        [Column("DueDate")]
        public DateTime DueDate { get; set; }
        [Column("MasterLastPractice")]
        public DateTime MasterLastPractice { get; set; } = DateTime.MinValue;
        [Column("PracticedTime")]
        public int PracticeCount { get; set; } = 0;
        [Column("Score")]
        public int Score { get; set; } = 0;
        [Column("CheckPoint")]
        public int CheckPointScore { get; set; } = 0;
    }
}
