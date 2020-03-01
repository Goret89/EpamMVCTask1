using EpamMVCTask1.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCTask1.Extensions
{
    public class AddData
    {
        public static void AddFeedback(Feedback feedback, BlogContext initializer)
        {
            feedback.FeedbackDate = DateTime.Now;
            //Initializer.feedbacks.Add(feedback);
            initializer.Feedbacks.Add(feedback);
            initializer.SaveChanges();
        }

       public static string ArticleTest200Symbols(BlogContext context)
        {
             return context.Articles.Where(t=>t.Text.Length < 20).ToString();
        }
    }
}