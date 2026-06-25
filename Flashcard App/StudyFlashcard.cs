using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Flashcard_App
{
    public partial class StudyFlashcard : Form
    {
        private List<Flashcard> flashcards;
        private Flashcard current;
        private int index;

        public StudyFlashcard()
        {
            InitializeComponent();

            flashcards = new List<Flashcard>();
            UpdateFlashcardList();

            current = flashcards.FirstOrDefault();
            index = 0;
        }

        private void UpdateFlashcardList()
        {
            flashcards.Clear();

            string dir = Directory.GetCurrentDirectory();

            string[] files = Directory.GetFiles(dir, "*.txt");

            for (int i = 0; i < files.Length; i++)
            {
                flashcards.Add(new Flashcard(files[i]));
            }
        }

        private void ShowFlashcard(Flashcard current)
        {
            FlashcardName_Label.Text = current.name;
            FlashcardSubject_Label.Text = current.subject;
            FlashcardCreator_Label.Text = current.creator;

            FlashcardFrontside_RichTextBox.Lines = current.frontside;
        }

        private void StudyFlashcard_VisibleChanged(object sender, EventArgs e)
        {
            UpdateFlashcardList();
            ShowFlashcard(current);
        }

        private void NextFlashcard_Button_Click(object sender, EventArgs e)
        {
            index = (index + 1) % flashcards.Count();
            current = flashcards.ElementAtOrDefault(index);

            FlashcardBackside_RichTextBox.Lines = new string[1];

            ShowFlashcard(current);
        }

        private void RevealBackside_Button_Click(object sender, EventArgs e)
        {
            FlashcardBackside_RichTextBox.Lines = current.backside;
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }
    }
}
