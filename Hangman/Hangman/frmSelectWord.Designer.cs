namespace Hangman
{
    partial class frmSelectWord
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblSelectWord = new System.Windows.Forms.Label();
            this.btnSubmitWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(15, 41);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(142, 20);
            this.txtWord.TabIndex = 0;
            // 
            // lblSelectWord
            // 
            this.lblSelectWord.AutoSize = true;
            this.lblSelectWord.Location = new System.Drawing.Point(12, 25);
            this.lblSelectWord.Name = "lblSelectWord";
            this.lblSelectWord.Size = new System.Drawing.Size(145, 13);
            this.lblSelectWord.TabIndex = 1;
            this.lblSelectWord.Text = "Select a word to be guessed:";
            // 
            // btnSubmitWord
            // 
            this.btnSubmitWord.Location = new System.Drawing.Point(164, 37);
            this.btnSubmitWord.Name = "btnSubmitWord";
            this.btnSubmitWord.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitWord.TabIndex = 2;
            this.btnSubmitWord.Text = "Submit";
            this.btnSubmitWord.UseVisualStyleBackColor = true;
            this.btnSubmitWord.Click += new System.EventHandler(this.btnSubmitWord_Click);
            // 
            // frmSelectWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.btnSubmitWord);
            this.Controls.Add(this.lblSelectWord);
            this.Controls.Add(this.txtWord);
            this.Name = "frmSelectWord";
            this.Text = "Select Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblSelectWord;
        private System.Windows.Forms.Button btnSubmitWord;
    }
}