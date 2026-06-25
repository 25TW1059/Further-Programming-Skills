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
            this.FlashcardCreator_Label = new System.Windows.Forms.Label();
            this.FlashcardName_Label = new System.Windows.Forms.Label();
            this.FlashcardSubject_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextFlashcard_Button = new System.Windows.Forms.Button();
            this.RevealBackside_Button = new System.Windows.Forms.Button();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlashcardFrontside_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.FlashcardBackside_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.FlashcardProperties_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlashcardProperties_GroupBox
            // 
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardCreator_Label);
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardName_Label);
            this.FlashcardProperties_GroupBox.Controls.Add(this.FlashcardSubject_Label);
            this.FlashcardProperties_GroupBox.Controls.Add(this.label6);
            this.FlashcardProperties_GroupBox.Controls.Add(this.label2);
            this.FlashcardProperties_GroupBox.Controls.Add(this.label5);
            this.FlashcardProperties_GroupBox.Location = new System.Drawing.Point(40, 35);
            this.FlashcardProperties_GroupBox.Name = "FlashcardProperties_GroupBox";
            this.FlashcardProperties_GroupBox.Size = new System.Drawing.Size(1800, 200);
            this.FlashcardProperties_GroupBox.TabIndex = 0;
            this.FlashcardProperties_GroupBox.TabStop = false;
            this.FlashcardProperties_GroupBox.Text = "Properties";
            // 
            // FlashcardCreator_Label
            // 
            this.FlashcardCreator_Label.AutoSize = true;
            this.FlashcardCreator_Label.Location = new System.Drawing.Point(133, 128);
            this.FlashcardCreator_Label.Name = "FlashcardCreator_Label";
            this.FlashcardCreator_Label.Size = new System.Drawing.Size(311, 25);
            this.FlashcardCreator_Label.TabIndex = 14;
            this.FlashcardCreator_Label.Text = "FLASHCARD CREATOR HERE";
            // 
            // FlashcardName_Label
            // 
            this.FlashcardName_Label.AutoSize = true;
            this.FlashcardName_Label.Location = new System.Drawing.Point(133, 48);
            this.FlashcardName_Label.Name = "FlashcardName_Label";
            this.FlashcardName_Label.Size = new System.Drawing.Size(270, 25);
            this.FlashcardName_Label.TabIndex = 12;
            this.FlashcardName_Label.Text = "FLASHCARD NAME HERE";
            // 
            // FlashcardSubject_Label
            // 
            this.FlashcardSubject_Label.AutoSize = true;
            this.FlashcardSubject_Label.Location = new System.Drawing.Point(133, 88);
            this.FlashcardSubject_Label.Name = "FlashcardSubject_Label";
            this.FlashcardSubject_Label.Size = new System.Drawing.Size(305, 25);
            this.FlashcardSubject_Label.TabIndex = 13;
            this.FlashcardSubject_Label.Text = "FLASHCARD SUBJECT HERE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Creator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subject:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlashcardBackside_RichTextBox);
            this.groupBox1.Controls.Add(this.FlashcardFrontside_RichTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
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
            this.RevealBackside_Button.Location = new System.Drawing.Point(797, 915);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frontside:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(903, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Backside:";
            // 
            // FlashcardFrontside_RichTextBox
            // 
            this.FlashcardFrontside_RichTextBox.Location = new System.Drawing.Point(13, 86);
            this.FlashcardFrontside_RichTextBox.Name = "FlashcardFrontside_RichTextBox";
            this.FlashcardFrontside_RichTextBox.ReadOnly = true;
            this.FlashcardFrontside_RichTextBox.Size = new System.Drawing.Size(870, 540);
            this.FlashcardFrontside_RichTextBox.TabIndex = 2;
            this.FlashcardFrontside_RichTextBox.Text = "";
            // 
            // FlashcardBackside_RichTextBox
            // 
            this.FlashcardBackside_RichTextBox.Location = new System.Drawing.Point(903, 86);
            this.FlashcardBackside_RichTextBox.Name = "FlashcardBackside_RichTextBox";
            this.FlashcardBackside_RichTextBox.ReadOnly = true;
            this.FlashcardBackside_RichTextBox.Size = new System.Drawing.Size(870, 540);
            this.FlashcardBackside_RichTextBox.TabIndex = 3;
            this.FlashcardBackside_RichTextBox.Text = "";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Flashcards";
            this.VisibleChanged += new System.EventHandler(this.StudyFlashcard_VisibleChanged);
            this.FlashcardProperties_GroupBox.ResumeLayout(false);
            this.FlashcardProperties_GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FlashcardProperties_GroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextFlashcard_Button;
        private System.Windows.Forms.Button RevealBackside_Button;
        private System.Windows.Forms.Button MainMenu_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FlashcardCreator_Label;
        private System.Windows.Forms.Label FlashcardName_Label;
        private System.Windows.Forms.Label FlashcardSubject_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox FlashcardFrontside_RichTextBox;
        private System.Windows.Forms.RichTextBox FlashcardBackside_RichTextBox;
    }
}