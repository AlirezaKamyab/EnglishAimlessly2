using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.Model
{
    public class WordModel
    {
        public WordModel() { }
        
        public enum WordType { adj, adv, v, n, phrase, proverb, auxilary}
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public WordType TypeOfWord { get; set; }
        public string Equivalent { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PracticedDate { get; set; }
        public int PracticeCount { get; set; }
    }
}
