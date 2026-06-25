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
            this.label2 = new System.Windows.Forms.Label();
            this.FlashcardName_TextBox = new System.Windows.Forms.TextBox();
            this.FlashcardText_GroupBox = new System.Windows.Forms.GroupBox();
            this.FlashcardBackside_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.FlashcardFrontside_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveFlashcard_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FlashcardSubject_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FlashcardCreator_TextBox = new System.Windows.Forms.TextBox();
            this.FlashcardProperties_GroupBox.SuspendLayout();
            this.FlashcardText_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlashcardProperties_GroupBox
            // 
            this.FlashcardProperties_GroupBox.Controls.Add(this.label6);
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardCreator_TextBox);
            this.FlashcardProperties_GroupBox.Controls.Add(this.label5);
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardSubject_TextBox);
            this.FlashcardProperties_GroupBox.Controls.Add(this.label2);
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardName_TextBox);
            this.FlashcardProperties_GroupBox.Location = new System.Drawing.Point(40, 35);
            this.FlashcardProperties_GroupBox.Name = "FlashcardProperties_GroupBox";
            this.FlashcardProperties_GroupBox.Size = new System.Drawing.Size(1800, 200);
            this.FlashcardProperties_GroupBox.TabIndex = 0;
            this.FlashcardProperties_GroupBox.TabStop = false;
            this.FlashcardProperties_GroupBox.Text = "Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // FlashcardName_TextBox
            // 
            this.FlashcardName_TextBox.Location = new System.Drawing.Point(133, 45);
            this.FlashcardName_TextBox.Name = "FlashcardName_TextBox";
            this.FlashcardName_TextBox.Size = new System.Drawing.Size(1620, 31);
            this.FlashcardName_TextBox.TabIndex = 0;
            // 
            // FlashcardText_GroupBox
            // 
            this.FlashcardText_GroupBox.Controls.Add(this.label4);
            this.FlashcardText_GroupBox.Controls.Add(this.label3);
            this.FlashcardText_GroupBox.Controls.Add(this.FlashcardBackside_RichTextBox);
            this.FlashcardText_GroupBox.Controls.Add(this.FlashcardFrontside_RichTextBox);
            this.FlashcardText_GroupBox.Location = new System.Drawing.Point(40, 250);
            this.FlashcardText_GroupBox.Name = "FlashcardText_GroupBox";
            this.FlashcardText_GroupBox.Size = new System.Drawing.Size(1800, 640);
            this.FlashcardText_GroupBox.TabIndex = 1;
            this.FlashcardText_GroupBox.TabStop = false;
            this.FlashcardText_GroupBox.Text = "Flashcard";
            // 
            // FlashcardBackside_RichTextBox
            // 
            this.FlashcardBackside_RichTextBox.Location = new System.Drawing.Point(903, 86);
            this.FlashcardBackside_RichTextBox.Name = "FlashcardBackside_RichTextBox";
            this.FlashcardBackside_RichTextBox.Size = new System.Drawing.Size(870, 540);
            this.FlashcardBackside_RichTextBox.TabIndex = 1;
            this.FlashcardBackside_RichTextBox.Text = "";
            // 
            // FlashcardFrontside_RichTextBox
            // 
            this.FlashcardFrontside_RichTextBox.Location = new System.Drawing.Point(13, 86);
            this.FlashcardFrontside_RichTextBox.Name = "FlashcardFrontside_RichTextBox";
            this.FlashcardFrontside_RichTextBox.Size = new System.Drawing.Size(870, 540);
            this.FlashcardFrontside_RichTextBox.TabIndex = 0;
            this.FlashcardFrontside_RichTextBox.Text = "";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frontside text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Backside text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subject:";
            // 
            // FlashcardSubject_TextBox
            // 
            this.FlashcardSubject_TextBox.Location = new System.Drawing.Point(133, 85);
            this.FlashcardSubject_TextBox.Name = "FlashcardSubject_TextBox";
            this.FlashcardSubject_TextBox.Size = new System.Drawing.Size(1620, 31);
            this.FlashcardSubject_TextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Creator:";
            // 
            // FlashcardCreator_TextBox
            // 
            this.FlashcardCreator_TextBox.Location = new System.Drawing.Point(133, 125);
            this.FlashcardCreator_TextBox.Name = "FlashcardCreator_TextBox";
            this.FlashcardCreator_TextBox.Size = new System.Drawing.Size(1620, 31);
            this.FlashcardCreator_TextBox.TabIndex = 4;
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
            this.FlashcardProperties_GroupBox.ResumeLayout(false);
            this.FlashcardProperties_GroupBox.PerformLayout();
            this.FlashcardText_GroupBox.ResumeLayout(false);
            this.FlashcardText_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FlashcardProperties_GroupBox;
        private System.Windows.Forms.GroupBox FlashcardText_GroupBox;
        private System.Windows.Forms.Button SaveFlashcard_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FlashcardName_TextBox;
        private System.Windows.Forms.RichTextBox FlashcardBackside_RichTextBox;
        private System.Windows.Forms.RichTextBox FlashcardFrontside_RichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FlashcardCreator_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FlashcardSubject_TextBox;
    }
}