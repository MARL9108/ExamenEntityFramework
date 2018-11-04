using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public byte Score { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }

        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }

    }
}
