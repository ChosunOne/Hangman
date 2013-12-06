namespace Hangman
{
    partial class frmGameWindow
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
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblBdy = new System.Windows.Forms.Label();
            this.lblBodyParts = new System.Windows.Forms.Label();
            this.lblBodyStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(13, 13);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(87, 13);
            this.lblGuessed.TabIndex = 0;
            this.lblGuessed.Text = "Guessed Letters:";
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.Location = new System.Drawing.Point(16, 30);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(389, 35);
            this.lblLetters.TabIndex = 1;
            this.lblLetters.Text = "_ _ _ _ _ _ _ _ _";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(19, 94);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(145, 13);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Input either a letter or a word:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(22, 111);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(22, 137);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(100, 23);
            this.btnLetter.TabIndex = 4;
            this.btnLetter.Text = "Guess Letter";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(22, 167);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(100, 23);
            this.btnWord.TabIndex = 5;
            this.btnWord.Text = "Guess Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(22, 209);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(152, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Return to Main Menu";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblBdy
            // 
            this.lblBdy.AutoSize = true;
            this.lblBdy.Location = new System.Drawing.Point(180, 13);
            this.lblBdy.Name = "lblBdy";
            this.lblBdy.Size = new System.Drawing.Size(60, 13);
            this.lblBdy.TabIndex = 7;
            this.lblBdy.Text = "Body parts:";
            // 
            // lblBodyParts
            // 
            this.lblBodyParts.AutoSize = true;
            this.lblBodyParts.Location = new System.Drawing.Point(238, 13);
            this.lblBodyParts.Name = "lblBodyParts";
            this.lblBodyParts.Size = new System.Drawing.Size(13, 13);
            this.lblBodyParts.TabIndex = 8;
            this.lblBodyParts.Text = "0";
            // 
            // lblBodyStatus
            // 
            this.lblBodyStatus.AutoSize = true;
            this.lblBodyStatus.Location = new System.Drawing.Point(183, 94);
            this.lblBodyStatus.Name = "lblBodyStatus";
            this.lblBodyStatus.Size = new System.Drawing.Size(282, 13);
            this.lblBodyStatus.TabIndex = 9;
            this.lblBodyStatus.Text = "Your right leg was attached to the gallows. You have died.";
            this.lblBodyStatus.Visible = false;
            // 
            // frmGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 245);
            this.Controls.Add(this.lblBodyStatus);
            this.Controls.Add(this.lblBodyParts);
            this.Controls.Add(this.lblBdy);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblGuessed);
            this.Name = "frmGameWindow";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLetter;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblBdy;
        private System.Windows.Forms.Label lblBodyParts;
        private System.Windows.Forms.Label lblBodyStatus;
    }
}