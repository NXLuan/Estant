
namespace Estant.View.CustomControl
{
    partial class VocabularyItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyItem));
            this.lbWord = new System.Windows.Forms.Label();
            this.pbVolume = new System.Windows.Forms.PictureBox();
            this.lbPhonetic = new System.Windows.Forms.Label();
            this.lbDefinition = new System.Windows.Forms.Label();
            this.pbMoreDetail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoreDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.lbWord.Location = new System.Drawing.Point(25, 12);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(67, 30);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "Word";
            // 
            // pbVolume
            // 
            this.pbVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVolume.Image = ((System.Drawing.Image)(resources.GetObject("pbVolume.Image")));
            this.pbVolume.Location = new System.Drawing.Point(31, 48);
            this.pbVolume.Name = "pbVolume";
            this.pbVolume.Size = new System.Drawing.Size(18, 20);
            this.pbVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVolume.TabIndex = 1;
            this.pbVolume.TabStop = false;
            this.pbVolume.Click += new System.EventHandler(this.pbVolume_Click);
            // 
            // lbPhonetic
            // 
            this.lbPhonetic.AutoSize = true;
            this.lbPhonetic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhonetic.Location = new System.Drawing.Point(55, 48);
            this.lbPhonetic.Name = "lbPhonetic";
            this.lbPhonetic.Size = new System.Drawing.Size(66, 20);
            this.lbPhonetic.TabIndex = 2;
            this.lbPhonetic.Text = "Phonetic";
            // 
            // lbDefinition
            // 
            this.lbDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDefinition.AutoEllipsis = true;
            this.lbDefinition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefinition.Location = new System.Drawing.Point(27, 78);
            this.lbDefinition.Name = "lbDefinition";
            this.lbDefinition.Size = new System.Drawing.Size(321, 26);
            this.lbDefinition.TabIndex = 3;
            this.lbDefinition.Text = "Definition";
            // 
            // pbMoreDetail
            // 
            this.pbMoreDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMoreDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMoreDetail.Image = ((System.Drawing.Image)(resources.GetObject("pbMoreDetail.Image")));
            this.pbMoreDetail.Location = new System.Drawing.Point(329, 100);
            this.pbMoreDetail.Name = "pbMoreDetail";
            this.pbMoreDetail.Size = new System.Drawing.Size(18, 23);
            this.pbMoreDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMoreDetail.TabIndex = 4;
            this.pbMoreDetail.TabStop = false;
            // 
            // VocabularyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbMoreDetail);
            this.Controls.Add(this.lbDefinition);
            this.Controls.Add(this.lbPhonetic);
            this.Controls.Add(this.pbVolume);
            this.Controls.Add(this.lbWord);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "VocabularyItem";
            this.Size = new System.Drawing.Size(368, 134);
            ((System.ComponentModel.ISupportInitialize)(this.pbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoreDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.PictureBox pbVolume;
        private System.Windows.Forms.Label lbPhonetic;
        private System.Windows.Forms.Label lbDefinition;
        private System.Windows.Forms.PictureBox pbMoreDetail;
    }
}
