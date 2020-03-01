using EpamMVCTask1.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogContext initializer = new BlogContext();

            var count = initializer.Articles.Select(t => t.Text).FirstOrDefault().Count();
            Console.WriteLine(count);
               
            var text = initializer.Articles.Select(t => t.Text).ToString()/*.FirstOrDefault()*/;

            foreach(var f in initializer.Articles.Select(t => t.Text).FirstOrDefault().Take(40))
                Console.Write(f);
            Console.WriteLine();
            //string str = "dgjdhghgedehrrgfeorfgerghe";
            //foreach(var f in str.Take(10))
            //    Console.Write(f);
            Console.ReadKey();
            //foreach (var f in initializ)er.Articles.Select(t => t.Text))
                //Console.WriteLine(f);
        }
    }
}
