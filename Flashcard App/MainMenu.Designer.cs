namespace Flashcard_App
{
    partial class MainMenu
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
            this.StudyFlashcards_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateFlashcards_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudyFlashcards_Button
            // 
            this.StudyFlashcards_Button.Location = new System.Drawing.Point(817, 711);
            this.StudyFlashcards_Button.Name = "StudyFlashcards_Button";
            this.StudyFlashcards_Button.Size = new System.Drawing.Size(261, 100);
            this.StudyFlashcards_Button.TabIndex = 1;
            this.StudyFlashcards_Button.Text = "Study Flashcards";
            this.StudyFlashcards_Button.UseVisualStyleBackColor = true;
            this.StudyFlashcards_Button.Click += new System.EventHandler(this.StudyFlashcards_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flashcard Study App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1250, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Now Better Than Ben\'s!";
            // 
            // CreateFlashcards_Button
            // 
            this.CreateFlashcards_Button.Location = new System.Drawing.Point(817, 558);
            this.CreateFlashcards_Button.Name = "CreateFlashcards_Button";
            this.CreateFlashcards_Button.Size = new System.Drawing.Size(261, 100);
            this.CreateFlashcards_Button.TabIndex = 4;
            this.CreateFlashcards_Button.Text = "Create Flashcards";
            this.CreateFlashcards_Button.UseVisualStyleBackColor = true;
            this.CreateFlashcards_Button.Click += new System.EventHandler(this.CreateFlashcards_Button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.CreateFlashcards_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudyFlashcards_Button);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StudyFlashcards_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateFlashcards_Button;
    }
}

