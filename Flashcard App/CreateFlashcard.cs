using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_App
{
    public partial class CreateFlashcard : Form
    {
        public CreateFlashcard()
        {
            InitializeComponent();
        }

        private void SaveFlashcard_Button_Click(object sender, EventArgs e)
        {
            string filename = FlashcardName_TextBox.Text.ToLower().Replace(" ", "") + ".txt";
            string filepath = Directory.GetCurrentDirectory() + $@"\{filename}";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(";begin flashcardname");
                writer.WriteLine(FlashcardName_TextBox.Text);
                writer.WriteLine(";end flashcardname");

                writer.WriteLine(";begin flashcardsubject");
                writer.WriteLine(FlashcardSubject_TextBox.Text);
                writer.WriteLine(";end flashcardsubject");

                writer.WriteLine(";begin flashcardcreator");
                writer.WriteLine(FlashcardCreator_TextBox.Text);
                writer.WriteLine(";end flashcardcreator");

                writer.WriteLine(";begin flashcardfrontside");
                writer.WriteLine(FlashcardFrontside_RichTextBox.Text);
                writer.WriteLine(";end flashcardfrontside");

                writer.WriteLine(";begin flashcardbackside");
                writer.WriteLine(FlashcardBackside_RichTextBox.Text);
                writer.WriteLine(";end flashcardbackside");
            }

            FlashcardName_TextBox.Clear();
            FlashcardSubject_TextBox.Clear();
            FlashcardCreator_TextBox.Clear();
            FlashcardFrontside_RichTextBox.Clear();
            FlashcardBackside_RichTextBox.Clear();

            MessageBox.Show($"Flashcard created successfully at '{filepath}'");
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }
    }
}
