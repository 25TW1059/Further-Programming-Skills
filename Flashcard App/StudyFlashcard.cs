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
    public partial class StudyFlashcard : Form
    {
        public StudyFlashcard()
        {
            InitializeComponent();
        }

        private void NextFlashcard_Button_Click(object sender, EventArgs e)
        {

        }

        private void RevealBackside_Button_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            Forms.menu.Show();
            this.Hide();
        }
    }
}
