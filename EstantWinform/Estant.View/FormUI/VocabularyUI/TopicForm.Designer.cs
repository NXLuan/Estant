
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
            this.buttonFlatImage3 = new Estant.View.CustomControl.ButtonFlatImage();
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
            this.flListVocab.Location = new System.Drawing.Point(9, 71);
            this.flListVocab.Margin = new System.Windows.Forms.Padding(2);
            this.flListVocab.Name = "flListVocab";
            this.flListVocab.Size = new System.Drawing.Size(622, 293);
            this.flListVocab.TabIndex = 3;
            // 
            // buttonFlatImage3
            // 
            this.buttonFlatImage3.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.buttonFlatImage3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFlatImage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.buttonFlatImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlatImage3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.buttonFlatImage3.IconButton = ((System.Drawing.Image)(resources.GetObject("buttonFlatImage3.IconButton")));
            this.buttonFlatImage3.Location = new System.Drawing.Point(424, 9);
            this.buttonFlatImage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFlatImage3.Name = "buttonFlatImage3";
            this.buttonFlatImage3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.buttonFlatImage3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonFlatImage3.Size = new System.Drawing.Size(187, 48);
            this.buttonFlatImage3.TabIndex = 2;
            this.buttonFlatImage3.TextButton = "   Result";
            this.buttonFlatImage3.TextColor = System.Drawing.Color.White;
            // 
            // btnPractice
            // 
            this.btnPractice.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.btnPractice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.btnPractice.IconButton = ((System.Drawing.Image)(resources.GetObject("btnPractice.IconButton")));
            this.btnPractice.Location = new System.Drawing.Point(221, 9);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnPractice.Size = new System.Drawing.Size(187, 48);
            this.btnPractice.TabIndex = 1;
            this.btnPractice.TextButton = "   Practice";
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.btnPractice.UserClick += new System.EventHandler(this.btnPractice_UserClick);
            // 
            // btnFlashCard
            // 
            this.btnFlashCard.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.btnFlashCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFlashCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnFlashCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlashCard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.btnFlashCard.IconButton = ((System.Drawing.Image)(resources.GetObject("btnFlashCard.IconButton")));
            this.btnFlashCard.Location = new System.Drawing.Point(20, 8);
            this.btnFlashCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlashCard.Name = "btnFlashCard";
            this.btnFlashCard.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnFlashCard.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnFlashCard.Size = new System.Drawing.Size(184, 49);
            this.btnFlashCard.TabIndex = 0;
            this.btnFlashCard.TextButton = "   Flashcards";
            this.btnFlashCard.TextColor = System.Drawing.Color.White;
            this.btnFlashCard.UserClick += new System.EventHandler(this.btnFlashCard_UserClick);
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this.flListVocab);
            this.Controls.Add(this.buttonFlatImage3);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnFlashCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TopicForm";
            this.Text = "TopicForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.ButtonFlatImage btnFlashCard;
        private CustomControl.ButtonFlatImage btnPractice;
        private CustomControl.ButtonFlatImage buttonFlatImage3;
        private System.Windows.Forms.FlowLayoutPanel flListVocab;
    }
}