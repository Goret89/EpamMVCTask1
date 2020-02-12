using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpamMVCTask1.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString CreateUlList(string[] items, string cssClassName)
        {
            TagBuilder tbUl = new TagBuilder("ul");
            tbUl.AddCssClass(cssClassName);

            TagBuilder li = new TagBuilder("li");

            for(int i = 0; i < items.Length; i++)
            {
                li.SetInnerText(items[i]);
                tbUl.InnerHtml += li.ToString();
            }


            return new MvcHtmlString(tbUl.ToString());
        }

        public static MvcHtmlString CreateSelectList(IList<string> items, string cssClassName, string name)
        {
            TagBuilder tbSelect = new TagBuilder("select");
            tbSelect.AddCssClass(cssClassName);
            tbSelect.MergeAttribute("name", name);

            TagBuilder option = new TagBuilder("option");

            //foreach(var it in items)
            //{
            for(int i = 0; i < items.Count; i++)
            {
                //option.MergeAttribute("selected", items[2]);
                option.SetInnerText(items[i]);
                tbSelect.InnerHtml += option.ToString();
            }
               
            //}

            return new MvcHtmlString(tbSelect.ToString());
        }
    }
}