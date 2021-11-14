
namespace Estant.View.FormUI.VocabularyUI
{
    partial class FlashCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashCardForm));
            this.pnFront = new System.Windows.Forms.Panel();
            this.lblPhonetic = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.pnBack = new System.Windows.Forms.Panel();
            this.lblExample = new System.Windows.Forms.Label();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblPartOfSpeech = new System.Windows.Forms.Label();
            this.pnTotalCard = new System.Windows.Forms.Panel();
            this.pnCurrentCard = new System.Windows.Forms.Panel();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.pnFront.SuspendLayout();
            this.pnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFront
            // 
            this.pnFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.pnFront.Controls.Add(this.lblPhonetic);
            this.pnFront.Controls.Add(this.lblWord);
            this.pnFront.Location = new System.Drawing.Point(103, 59);
            this.pnFront.Name = "pnFront";
            this.pnFront.Size = new System.Drawing.Size(398, 305);
            this.pnFront.TabIndex = 0;
            // 
            // lblPhonetic
            // 
            this.lblPhonetic.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonetic.ForeColor = System.Drawing.Color.White;
            this.lblPhonetic.Location = new System.Drawing.Point(4, 174);
            this.lblPhonetic.Name = "lblPhonetic";
            this.lblPhonetic.Size = new System.Drawing.Size(391, 67);
            this.lblPhonetic.TabIndex = 1;
            this.lblPhonetic.Text = "/ banker /";
            this.lblPhonetic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.White;
            this.lblWord.Location = new System.Drawing.Point(3, 92);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(392, 81);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "banker";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.White;
            this.pnBack.Controls.Add(this.lblExample);
            this.pnBack.Controls.Add(this.lblDefinition);
            this.pnBack.Controls.Add(this.lblPartOfSpeech);
            this.pnBack.Location = new System.Drawing.Point(103, 59);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(398, 305);
            this.pnBack.TabIndex = 1;
            // 
            // lblExample
            // 
            this.lblExample.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.ForeColor = System.Drawing.Color.Black;
            this.lblExample.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblExample.Location = new System.Drawing.Point(9, 245);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(386, 60);
            this.lblExample.TabIndex = 2;
            this.lblExample.Text = "E.g. an eagle in flight";
            this.lblExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefinition
            // 
            this.lblDefinition.BackColor = System.Drawing.Color.White;
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefinition.ForeColor = System.Drawing.Color.Black;
            this.lblDefinition.Location = new System.Drawing.Point(16, 68);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(366, 166);
            this.lblDefinition.TabIndex = 1;
            this.lblDefinition.Text = "the place to which someone or something is going or being sent";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartOfSpeech
            // 
            this.lblPartOfSpeech.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartOfSpeech.ForeColor = System.Drawing.Color.Black;
            this.lblPartOfSpeech.Location = new System.Drawing.Point(3, 32);
            this.lblPartOfSpeech.Name = "lblPartOfSpeech";
            this.lblPartOfSpeech.Size = new System.Drawing.Size(392, 31);
            this.lblPartOfSpeech.TabIndex = 0;
            this.lblPartOfSpeech.Text = "(noun)";
            this.lblPartOfSpeech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTotalCard
            // 
            this.pnTotalCard.BackColor = System.Drawing.Color.DarkSalmon;
            this.pnTotalCard.Location = new System.Drawing.Point(136, 30);
            this.pnTotalCard.Name = "pnTotalCard";
            this.pnTotalCard.Size = new System.Drawing.Size(325, 10);
            this.pnTotalCard.TabIndex = 2;
            // 
            // pnCurrentCard
            // 
            this.pnCurrentCard.BackColor = System.Drawing.Color.OrangeRed;
            this.pnCurrentCard.Location = new System.Drawing.Point(136, 30);
            this.pnCurrentCard.Name = "pnCurrentCard";
            this.pnCurrentCard.Size = new System.Drawing.Size(219, 10);
            this.pnCurrentCard.TabIndex = 3;
            // 
            // pbPrev
            // 
            this.pbPrev.Image = ((System.Drawing.Image)(resources.GetObject("pbPrev.Image")));
            this.pbPrev.Location = new System.Drawing.Point(46, 189);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(38, 42);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrev.TabIndex = 4;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.pbPrev_Click);
            // 
            // pbNext
            // 
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(523, 189);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(38, 42);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 5;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.BackColor = System.Drawing.Color.White;
            this.btnSaveWord.FlatAppearance.BorderSize = 0;
            this.btnSaveWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveWord.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveWord.Image")));
            this.btnSaveWord.Location = new System.Drawing.Point(190, 417);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(52, 52);
            this.btnSaveWord.TabIndex = 6;
            this.btnSaveWord.UseVisualStyleBackColor = false;
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.White;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Image = ((System.Drawing.Image)(resources.GetObject("btnRotate.Image")));
            this.btnRotate.Location = new System.Drawing.Point(280, 417);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(52, 52);
            this.btnRotate.TabIndex = 7;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.White;
            this.btnAudio.FlatAppearance.BorderSize = 0;
            this.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnAudio.Image")));
            this.btnAudio.Location = new System.Drawing.Point(370, 417);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(52, 52);
            this.btnAudio.TabIndex = 8;
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // FlashCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 506);
            this.Controls.Add(this.pnBack);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnSaveWord);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.pnCurrentCard);
            this.Controls.Add(this.pnTotalCard);
            this.Controls.Add(this.pnFront);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlashCardForm";
            this.Text = "FlashCardForm";
            this.pnFront.ResumeLayout(false);
            this.pnBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFront;
        private System.Windows.Forms.Label lblPhonetic;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblPartOfSpeech;
        private System.Windows.Forms.Panel pnTotalCard;
        private System.Windows.Forms.Panel pnCurrentCard;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnAudio;
    }
}