using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public int CourseID { get; set; }
        public string CompletionInfo { get; set; }
        public double Percentage { get; set; }
        public DateTime DueDate { get; set; }

        public virtual Course Course { get; set; }
    }
}