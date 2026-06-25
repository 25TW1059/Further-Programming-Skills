using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard_App
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void StudyFlashcards_Button_Click(object sender, EventArgs e)
        {
            Forms.study.Show();
            this.Hide();
        }

        private void CreateFlashcards_Button_Click(object sender, EventArgs e)
        {
            Forms.create.Show();
            this.Hide();
        }
    }
}
