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
using System.Xml.Linq;

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

            string name = FlashcardName_TextBox.Text;
            string subject = FlashcardSubject_TextBox.Text;
            string creator = FlashcardCreator_TextBox.Text;
            string[] frontside = FlashcardFrontside_RichTextBox.Lines;
            string[] backside = FlashcardBackside_RichTextBox.Lines;

            Flashcard flashcard = new Flashcard(name, subject, creator, frontside, backside);

            flashcard.WriteToFile();

            FlashcardName_TextBox.Clear();
            FlashcardSubject_TextBox.Clear();
            FlashcardCreator_TextBox.Clear();
            FlashcardFrontside_RichTextBox.Clear();
            FlashcardBackside_RichTextBox.Clear();

            MessageBox.Show($"Flashcard created successfully at '{flashcard.filepath}'");
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }
    }
}
