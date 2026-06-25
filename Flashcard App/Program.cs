using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_App
{
    internal static class Forms
    {
        public static MainMenu menu = new MainMenu();
        public static CreateFlashcard create = new CreateFlashcard();
        public static StudyFlashcard study = new StudyFlashcard();
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
