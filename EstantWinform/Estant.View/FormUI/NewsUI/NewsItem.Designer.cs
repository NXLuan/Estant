
namespace Estant.View.FormUI.NewsUI
{
    partial class NewsItem
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnContent = new System.Windows.Forms.Panel();
            this.lbPublishedAt = new System.Windows.Forms.Label();
            this.lbSourceName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbImage.Location = new System.Drawing.Point(596, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(161, 116);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.lbPublishedAt);
            this.pnContent.Controls.Add(this.lbSourceName);
            this.pnContent.Controls.Add(this.lbTitle);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnContent.Size = new System.Drawing.Size(596, 116);
            this.pnContent.TabIndex = 2;
            // 
            // lbPublishedAt
            // 
            this.lbPublishedAt.AutoEllipsis = true;
            this.lbPublishedAt.AutoSize = true;
            this.lbPublishedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublishedAt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublishedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lbPublishedAt.Location = new System.Drawing.Point(20, 81);
            this.lbPublishedAt.Name = "lbPublishedAt";
            this.lbPublishedAt.Size = new System.Drawing.Size(50, 20);
            this.lbPublishedAt.TabIndex = 2;
            this.lbPublishedAt.Text = "label3";
            this.lbPublishedAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSourceName
            // 
            this.lbSourceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSourceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSourceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.lbSourceName.Location = new System.Drawing.Point(20, 43);
            this.lbSourceName.Name = "lbSourceName";
            this.lbSourceName.Size = new System.Drawing.Size(556, 38);
            this.lbSourceName.TabIndex = 1;
            this.lbSourceName.Text = "label2";
            this.lbSourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(20, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(59, 23);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // NewsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pbImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "NewsItem";
            this.Size = new System.Drawing.Size(757, 116);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Label lbPublishedAt;
        private System.Windows.Forms.Label lbSourceName;
        private System.Windows.Forms.Label lbTitle;
    }
}
