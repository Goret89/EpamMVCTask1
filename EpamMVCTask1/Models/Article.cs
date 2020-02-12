using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCTask1.Models
{
    public class Article
    {
        public string Name { get; set; }
        public DateTime DatePublish { get; set; }
        public string Text { get; set; }
    }
}