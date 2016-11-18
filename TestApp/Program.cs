using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressDotNet;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WordPressConnector wordpress = new WordPressConnector("http://localhost/wordpress");
            var task = wordpress.GetAuthorAsync(1);

            task.Wait();
            var result = task.Result;


        }

      


    }
}
