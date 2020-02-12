using EpamMVCTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpamMVCTask1.Extensions
{
    public class Initializer
    {
        public Article[] articleList;
        public IList<Article> articles = new List<Article>();
        public static IList<Feedback> feedbacks = new List<Feedback>();

        public Initializer()
        {
            articleList = new Article[]{
                new Article() { Name = "Apple", DatePublish = DateTime.Now,
                    Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div." },
                new Article() { Name = "Orange", DatePublish = DateTime.Now,
                    Text = "Also notice that we have set overflow:auto to sidenav. " +
                    "This will add a scrollbar when the sidenav is too long " +
                    "(for example if it has over 50 links inside of it)." },
                new Article() { Name = "Banana", DatePublish = DateTime.Now,
                    Text = "Try to scroll this area, and see how the " +
                    "sidenav sticks to the page" },
                new Article() { Name = "Pine apple", DatePublish = DateTime.Now,
                    Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div." }
            };
            articles.Add(new Article()
            {
                Name = "Article 1",
                DatePublish = DateTime.Now,
                Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div."
            });
            articles.Add(new Article()
            {
                Name = "Article 2",
                DatePublish = DateTime.Now,
                Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div."
            });
            articles.Add(new Article()
            {
                Name = "Article 3",
                DatePublish = DateTime.Now,
                Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div."
            });
            articles.Add(new Article()
            {
                Name = "Article 4",
                DatePublish = DateTime.Now,
                Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div."
            });
            articles.Add(new Article()
            {
                Name = "Article 5",
                DatePublish = DateTime.Now,
                Text = "Notice that this div element has a left margin of 25%. " +
                    "This is because the side navigation is set to 25% width. " +
                    "If you remove the margin, the sidenav will overlay/sit on top of this div."
            });

            feedbacks.Add(new Feedback() { Name = "Vasia", FeedbackDate = DateTime.Now, Text = "I like this item" });
            feedbacks.Add(new Feedback() { Name = "Olga", FeedbackDate = DateTime.Now, Text = "I did not like this item. Don't buy it" });
            feedbacks.Add(new Feedback() { Name = "Svetlana", FeedbackDate = DateTime.Now, Text = "So-so. I did not get a delight" });
            feedbacks.Add(new Feedback() { Name = "Nazar", FeedbackDate = DateTime.Now, Text = "Before buying you should think twice " });
            feedbacks.Add(new Feedback() { Name = "Petia", FeedbackDate = DateTime.Now, Text = "Товар в точности соответствует описанию. Я проверил его один раз, чтобы увидеть, все ли работает, и я могу подтвердить, что это нормально. Однако продавец должен был продлить гарантию во время доставки, так как была задержка. Я ценю, что он ответил в тот же день, и я рекомендую его как продавца, но это pitty, это займет 2 месяца доставки в Варну, Болгарию. Это может быть из-за рождественского периода, но в любом случае. 5 звезд для точного описания и общения с продавцом и 2 звезды для службы доставки. " });
            feedbacks.Add(new Feedback() { Name = "Taras", FeedbackDate = DateTime.Now, Text = "Качество продукции удивило меня поздравления, китайцы преобладают во всем мире. Спасибо." });
        }
    }   
}