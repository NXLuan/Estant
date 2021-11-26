
namespace Estant.View.FormUI.VocabularyUI
{
    partial class SavedWordItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedWordItem));
            this.lbWord = new System.Windows.Forms.Label();
            this.pbOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWord
            // 
            this.lbWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.lbWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWord.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.ForeColor = System.Drawing.Color.White;
            this.lbWord.Location = new System.Drawing.Point(0, 0);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(201, 105);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "label1";
            this.lbWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbOpen
            // 
            this.pbOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.pbOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOpen.Image = ((System.Drawing.Image)(resources.GetObject("pbOpen.Image")));
            this.pbOpen.Location = new System.Drawing.Point(170, 75);
            this.pbOpen.Name = "pbOpen";
            this.pbOpen.Size = new System.Drawing.Size(24, 24);
            this.pbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpen.TabIndex = 1;
            this.pbOpen.TabStop = false;
            this.pbOpen.Click += new System.EventHandler(this.pbOpen_Click);
            // 
            // SavedWordItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbOpen);
            this.Controls.Add(this.lbWord);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "SavedWordItem";
            this.Size = new System.Drawing.Size(201, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.PictureBox pbOpen;
    }
}
