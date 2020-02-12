using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCTask1.Models
{
    public class Feedback
    {
        public string Name { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string Text { get; set; }
    }
}