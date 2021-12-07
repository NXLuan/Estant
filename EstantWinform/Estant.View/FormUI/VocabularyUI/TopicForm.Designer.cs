
namespace Estant.View.FormUI.VocabularyUI
{
    partial class TopicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicForm));
            this.flListVocab = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPractice = new Estant.View.CustomControl.ButtonFlatImage();
            this.btnFlashCard = new Estant.View.CustomControl.ButtonFlatImage();
            this.SuspendLayout();
            // 
            // flListVocab
            // 
            this.flListVocab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flListVocab.AutoScroll = true;
            this.flListVocab.Location = new System.Drawing.Point(12, 87);
            this.flListVocab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flListVocab.Name = "flListVocab";
            this.flListVocab.Size = new System.Drawing.Size(829, 361);
            this.flListVocab.TabIndex = 3;
            // 
            // btnPractice
            // 
            this.btnPractice.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.btnPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.btnPractice.IconButton = ((System.Drawing.Image)(resources.GetObject("btnPractice.IconButton")));
            this.btnPractice.Location = new System.Drawing.Point(423, 11);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnPractice.Size = new System.Drawing.Size(370, 59);
            this.btnPractice.TabIndex = 1;
            this.btnPractice.TextButton = "   Practice";
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.btnPractice.UserClick += new System.EventHandler(this.btnPractice_UserClick);
            // 
            // btnFlashCard
            // 
            this.btnFlashCard.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.btnFlashCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnFlashCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlashCard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.btnFlashCard.IconButton = ((System.Drawing.Image)(resources.GetObject("btnFlashCard.IconButton")));
            this.btnFlashCard.Location = new System.Drawing.Point(23, 10);
            this.btnFlashCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlashCard.Name = "btnFlashCard";
            this.btnFlashCard.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnFlashCard.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnFlashCard.Size = new System.Drawing.Size(367, 60);
            this.btnFlashCard.TabIndex = 0;
            this.btnFlashCard.TextButton = "   Flashcards";
            this.btnFlashCard.TextColor = System.Drawing.Color.White;
            this.btnFlashCard.UserClick += new System.EventHandler(this.btnFlashCard_UserClick);
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.flListVocab);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnFlashCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TopicForm";
            this.Text = "TopicForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.ButtonFlatImage btnFlashCard;
        private CustomControl.ButtonFlatImage btnPractice;
        private System.Windows.Forms.FlowLayoutPanel flListVocab;
    }
}