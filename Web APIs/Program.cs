using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Web_APIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://xkcd.com/info.0.json");
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/json; charset=utf-8;";

            string text;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            Console.WriteLine(text + "\n\n");

            Comic comic = JsonSerializer.Deserialize<Comic>(text);


            Console.WriteLine($"Title: {comic.title}, Published: {comic.day}-{comic.month}-{comic.year}\n{comic.alt}");

            Console.ReadKey();
        }
    }
}
