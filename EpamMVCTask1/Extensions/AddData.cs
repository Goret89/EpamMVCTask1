using EpamMVCTask1.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCTask1.Extensions
{
    public class AddData
    {
        public static void AddFeedback(DLL.Models.Feedback feedback, BlogContext initializer)
        {
            feedback.FeedbackDate = DateTime.Now;
            //Initializer.feedbacks.Add(feedback);
            initializer.Feedbacks.Add(feedback);
            initializer.SaveChanges();
        }
    }
}