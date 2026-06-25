namespace Flashcard_App
{
    partial class StudyFlashcard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlashcardProperties_GroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextFlashcard_Button = new System.Windows.Forms.Button();
            this.RevealBackside_Button = new System.Windows.Forms.Button();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlashcardProperties_GroupBox
            // 
            this.FlashcardProperties_GroupBox.Location = new System.Drawing.Point(40, 35);
            this.FlashcardProperties_GroupBox.Name = "FlashcardProperties_GroupBox";
            this.FlashcardProperties_GroupBox.Size = new System.Drawing.Size(1800, 200);
            this.FlashcardProperties_GroupBox.TabIndex = 0;
            this.FlashcardProperties_GroupBox.TabStop = false;
            this.FlashcardProperties_GroupBox.Text = "Properties";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(40, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1800, 640);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flashcard";
            // 
            // NextFlashcard_Button
            // 
            this.NextFlashcard_Button.Location = new System.Drawing.Point(1540, 915);
            this.NextFlashcard_Button.Name = "NextFlashcard_Button";
            this.NextFlashcard_Button.Size = new System.Drawing.Size(300, 60);
            this.NextFlashcard_Button.TabIndex = 2;
            this.NextFlashcard_Button.Text = "Next Card";
            this.NextFlashcard_Button.UseVisualStyleBackColor = true;
            this.NextFlashcard_Button.Click += new System.EventHandler(this.NextFlashcard_Button_Click);
            // 
            // RevealBackside_Button
            // 
            this.RevealBackside_Button.Location = new System.Drawing.Point(810, 915);
            this.RevealBackside_Button.Name = "RevealBackside_Button";
            this.RevealBackside_Button.Size = new System.Drawing.Size(300, 60);
            this.RevealBackside_Button.TabIndex = 3;
            this.RevealBackside_Button.Text = "Reveal Backside";
            this.RevealBackside_Button.UseVisualStyleBackColor = true;
            this.RevealBackside_Button.Click += new System.EventHandler(this.RevealBackside_Button_Click);
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.Location = new System.Drawing.Point(40, 915);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Size = new System.Drawing.Size(300, 60);
            this.MainMenu_Button.TabIndex = 4;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.UseVisualStyleBackColor = true;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            // 
            // StudyFlashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.RevealBackside_Button);
            this.Controls.Add(this.NextFlashcard_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FlashcardProperties_GroupBox);
            this.Name = "StudyFlashcard";
            this.Text = "Study Flashcards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FlashcardProperties_GroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextFlashcard_Button;
        private System.Windows.Forms.Button RevealBackside_Button;
        private System.Windows.Forms.Button MainMenu_Button;
    }
}