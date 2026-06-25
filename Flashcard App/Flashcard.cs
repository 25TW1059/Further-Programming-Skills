using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Flashcard_App
{
    internal class Flashcard
    {
        public string name { get; }
        public string subject { get; }
        public string creator { get; }

        public string[] frontside { get; }
        public string[] backside { get; }

        public string filename { get => name.ToLower().Replace(" ", "") + ".txt"; }
        public string filepath { get => Directory.GetCurrentDirectory() + $@"\{filename}"; }

        public Flashcard(string name, string subject, string creator, string[] frontside, string[] backside)
        {
            this.name = name;
            this.subject = subject;
            this.creator = creator;
            this.frontside = frontside;
            this.backside = backside;
        }

        public Flashcard(string filepath)
        {
            string name = "";
            string subject = "";
            string creator = "";

            List<string> frontside = new List<string>();
            List<string> backside = new List<string>();

            using (StreamReader reader = new StreamReader(filepath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line.StartsWith(";"))
                    {
                        switch (line)
                        {
                            case ";begin flashcardname":
                                name = reader.ReadLine();
                                break;

                            case ";begin flashcardsubject":
                                subject = reader.ReadLine();
                                break;

                            case ";begin flashcardcreator":
                                creator = reader.ReadLine();
                                break;

                            case ";begin flashcardfrontside":
                                while (!reader.EndOfStream)
                                {
                                    string frontLine = reader.ReadLine();

                                    if (frontLine == ";end flashcardfrontside")
                                        break;

                                    frontside.Add(frontLine);
                                }
                                break;

                            case ";begin flashcardbackside":
                                while (!reader.EndOfStream)
                                {
                                    string backLine = reader.ReadLine();

                                    if (backLine == ";end flashcardbackside")
                                        break;

                                    backside.Add(backLine);
                                }
                                break;
                        }
                    }
                }
            }

            this.name = name;
            this.subject = subject;
            this.creator = creator;
            this.frontside = frontside.ToArray();
            this.backside = backside.ToArray();
        }

        public string WriteToFile()
        {
            string filename = name.ToLower().Replace(" ", "") + ".txt";
            string filepath = Directory.GetCurrentDirectory() + $@"\{filename}";

            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.WriteLine(";begin flashcardname");
                writer.WriteLine(name);
                writer.WriteLine(";end flashcardname");

                writer.WriteLine(";begin flashcardsubject");
                writer.WriteLine(subject);
                writer.WriteLine(";end flashcardsubject");

                writer.WriteLine(";begin flashcardcreator");
                writer.WriteLine(creator);
                writer.WriteLine(";end flashcardcreator");

                writer.WriteLine(";begin flashcardfrontside");
                foreach (string line in frontside) writer.WriteLine(line);
                writer.WriteLine(";end flashcardfrontside");

                writer.WriteLine(";begin flashcardbackside");
                foreach (string line in backside) writer.WriteLine(line);
                writer.WriteLine(";end flashcardbackside");
            }

            return filepath;
        }
    }
}
