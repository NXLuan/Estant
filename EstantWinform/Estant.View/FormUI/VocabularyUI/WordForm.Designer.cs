
namespace Estant.View.FormUI.VocabularyUI
{
    partial class WordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBookMark = new System.Windows.Forms.PictureBox();
            this.pnMeaning = new System.Windows.Forms.Panel();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.lbPhonetic = new System.Windows.Forms.Label();
            this.lbWord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbBookMark);
            this.panel1.Controls.Add(this.pnMeaning);
            this.panel1.Controls.Add(this.pbVolume);
            this.panel1.Controls.Add(this.lbPhonetic);
            this.panel1.Controls.Add(this.lbWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 512);
            this.panel1.TabIndex = 0;
            // 
            // pbBookMark
            // 
            this.pbBookMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBookMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBookMark.Image = ((System.Drawing.Image)(resources.GetObject("pbBookMark.Image")));
            this.pbBookMark.Location = new System.Drawing.Point(680, 33);
            this.pbBookMark.Name = "pbBookMark";
            this.pbBookMark.Size = new System.Drawing.Size(39, 39);
            this.pbBookMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBookMark.TabIndex = 4;
            this.pbBookMark.TabStop = false;
            this.pbBookMark.Click += new System.EventHandler(this.pbBookMark_Click);
            // 
            // pnMeaning
            // 
            this.pnMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMeaning.AutoScroll = true;
            this.pnMeaning.Location = new System.Drawing.Point(0, 101);
            this.pnMeaning.Name = "pnMeaning";
            this.pnMeaning.Size = new System.Drawing.Size(740, 411);
            this.pnMeaning.TabIndex = 3;
            // 
            // pbVolume
            // 
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(35, 60);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(24, 24);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolume.TabIndex = 2;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.pbVolume_Click);
            // 
            // lbPhonetic
            // 
            this.lbPhonetic.AutoSize = true;
            this.lbPhonetic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonetic.Location = new System.Drawing.Point(66, 57);
            this.lbPhonetic.Name = "lbPhonetic";
            this.lbPhonetic.Size = new System.Drawing.Size(88, 28);
            this.lbPhonetic.TabIndex = 1;
            this.lbPhonetic.Text = "Phonetic";
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.lbWord.Location = new System.Drawing.Point(28, 16);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(87, 38);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "Word";
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordForm";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.Text = "WordForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbPhonetic;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.Panel pnMeaning;
        private System.Windows.Forms.PictureBox pbBookMark;
    }
}