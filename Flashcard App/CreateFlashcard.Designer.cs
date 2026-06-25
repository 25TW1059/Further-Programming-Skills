namespace Flashcard_App
{
    partial class CreateFlashcard
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
            this.FlashcardText_GroupBox = new System.Windows.Forms.GroupBox();
            this.SaveFlashcard_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // FlashcardText_GroupBox
            // 
            this.FlashcardText_GroupBox.Location = new System.Drawing.Point(40, 250);
            this.FlashcardText_GroupBox.Name = "FlashcardText_GroupBox";
            this.FlashcardText_GroupBox.Size = new System.Drawing.Size(1800, 640);
            this.FlashcardText_GroupBox.TabIndex = 1;
            this.FlashcardText_GroupBox.TabStop = false;
            this.FlashcardText_GroupBox.Text = "Flashcard";
            // 
            // SaveFlashcard_Button
            // 
            this.SaveFlashcard_Button.Location = new System.Drawing.Point(1540, 915);
            this.SaveFlashcard_Button.Name = "SaveFlashcard_Button";
            this.SaveFlashcard_Button.Size = new System.Drawing.Size(300, 60);
            this.SaveFlashcard_Button.TabIndex = 2;
            this.SaveFlashcard_Button.Text = "Save Flashcard";
            this.SaveFlashcard_Button.UseVisualStyleBackColor = true;
            this.SaveFlashcard_Button.Click += new System.EventHandler(this.SaveFlashcard_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 933);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(882, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Warning: None of this data is validated. Enter dangerous/unexpected data at your " +
    "own risk!";
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
            // CreateFlashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFlashcard_Button);
            this.Controls.Add(this.FlashcardText_GroupBox);
            this.Controls.Add(this.FlashcardProperties_GroupBox);
            this.Name = "CreateFlashcard";
            this.Text = "Create Flashcard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FlashcardProperties_GroupBox;
        private System.Windows.Forms.GroupBox FlashcardText_GroupBox;
        private System.Windows.Forms.Button SaveFlashcard_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu_Button;
    }
}