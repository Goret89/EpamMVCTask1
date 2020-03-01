using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamMVCTask1.DLL.Models
{
    public class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var articles = new List<Article>() {
                new Article()
                {
                    Name = "Article 1",
                    DatePublish = DateTime.Now,
                    Text = "1 Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. " +
                        "If you remove the margin, the sidenav will overlay/sit on top of this div."+
                        "Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. "
                    //    ,
                    //Tags = new List<Tag>(){ tags[0], tags[1], tags[2], tags[3], tags[4], tags[5] }
                },
                new Article()
                {
                    Name = "Article 2",
                    DatePublish = DateTime.Now,
                    Text = "2 Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. " +
                        "If you remove the margin, the sidenav will overlay/sit on top of this div."
                    //    ,
                    //Tags = new List<Tag>(){ tags[0], tags[1], tags[2], tags[3], tags[4], tags[5] }
                },
                new Article()
                {
                    Name = "Article 3",
                    DatePublish = DateTime.Now,
                    Text = "3 Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. " +
                        "If you remove the margin, the sidenav will overlay/sit on top of this div."+
                        "Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. "
                    //    ,
                    //Tags = new List<Tag>(){ tags[0], tags[1], tags[2], tags[3], tags[4], tags[5] }
                },
                new Article()
                {
                    Name = "Article 4",
                    DatePublish = DateTime.Now,
                    Text = "4 Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. " +
                        "If you remove the margin, the sidenav will overlay/sit on top of this div."+
                        "Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. "
                    //    ,
                    //Tags = new List<Tag>(){ tags[0], tags[1], tags[2], tags[3], tags[4], tags[5] }
                },
                new Article()
                {
                    Name = "Article 5",
                    DatePublish = DateTime.Now,
                    Text = "5 Notice that this div element has a left margin of 25%. " +
                        "This is because the side navigation is set to 25% width. " +
                        "If you remove the margin, the sidenav will overlay/sit on top of this div."
                    //    ,
                    //Tags = new List<Tag>(){ tags[0], tags[1], tags[2], tags[3], tags[4], tags[5] }
                },
            };
            articles.ForEach(m => context.Articles.Add(m));

            context.SaveChanges();

            var tags = new List<Tag>()
            {
                new Tag(){ Name = "div"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[0] 
                } },
                new Tag(){ Name="margin"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[4] 
                } },
                new Tag(){ Name = "side navigation"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[4]
                } },
                new Tag(){ Name="sidenav"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[4]
                } },
                new Tag(){ Name="left"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[4]
                } },
                new Tag(){ Name="top"
                , Articles = new List<Article>(){ articles[0], articles[1], articles[2], articles[3], articles[4]
                } }
            };

            tags.ForEach(m => context.Tags.Add(m));

            context.SaveChanges();

            var feedbacks = new List<Feedback>(){
                new Feedback() {  Name = "Vasia", FeedbackDate = DateTime.Now, Text = "I like this item" },
                new Feedback() { Name = "Olga", FeedbackDate = DateTime.Now, Text = "I did not like this item. Don't buy it" },
                new Feedback() { Name = "Svetlana", FeedbackDate = DateTime.Now, Text = "So-so. I did not get a delight" },
                new Feedback() {  Name = "Nazar", FeedbackDate = DateTime.Now, Text = "Before buying you should think twice " },
                new Feedback() {  Name = "Petia", FeedbackDate = DateTime.Now, Text = "Товар в точности соответствует описанию. Я проверил его один раз, чтобы увидеть, все ли работает, и я могу подтвердить, что это нормально. Однако продавец должен был продлить гарантию во время доставки, так как была задержка. Я ценю, что он ответил в тот же день, и я рекомендую его как продавца, но это pitty, это займет 2 месяца доставки в Варну, Болгарию. Это может быть из-за рождественского периода, но в любом случае. 5 звезд для точного описания и общения с продавцом и 2 звезды для службы доставки. " },
                new Feedback() {  Name = "Taras", FeedbackDate = DateTime.Now, Text = "Качество продукции удивило меня поздравления, китайцы преобладают во всем мире. Спасибо." }
            };
            feedbacks.ForEach(mc => context.Feedbacks.Add(mc));

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
