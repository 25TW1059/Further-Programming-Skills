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
            string startingWord = "Hello";

            Console.Write(startingWord + " ");

            string previousWord = startingWord;

            do
            {
                string nextWord = NextWord(previousWord);
                Console.Write(nextWord + " ");
                previousWord = nextWord;
            } while (previousWord != ".");
        }

        static string NextWord(string word_previous)
        {
            /*
             * Creates a web request to access the list of suggested next
             * words from the API, then selects and returns the first word
             * that is not a full stop.
            */

            WebRequest request = WebRequest.Create($"https://api.datamuse.com/words?lc={word_previous}&sp=*");
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/json; charset=utf-8;";

            string response_text;

            WebResponse response_json = request.GetResponse();
            using (StreamReader reader = new StreamReader(response_json.GetResponseStream()))
            {
                response_text = reader.ReadToEnd();
            }
           
            List<Word> response_suggestedWords = JsonSerializer.Deserialize<List<Word>>(response_text);

            string word_next = "";

            Random rng = new Random();
            foreach (Word w in response_suggestedWords)
            {
                if (w.word == ".")
                {
                    if (rng.NextDouble() < 0.05)
                    {
                        word_next = w.word;
                        break;
                    }
                }
                else
                {
                    if (rng.NextDouble() < 0.7)
                    {
                        continue;
                    }
                    word_next = w.word;
                    break;
                }
            }

            return word_next;
        }
    }
}
