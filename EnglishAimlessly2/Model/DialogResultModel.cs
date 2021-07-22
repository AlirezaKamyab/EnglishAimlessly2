using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.Model
{
    public enum Result { Yes, No, Cancel };
    public class DialogResultModel
    {
        public DialogResultModel() { }
        public DialogResultModel(Result result)
        {
            DialogResult = result;
        }
        public Result DialogResult { get; set; }
    }
}
