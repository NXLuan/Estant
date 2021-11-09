
namespace Estant.View.CustomControl
{
    partial class TabNavigate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabNavigate));
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.lbTabName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArrow
            // 
            this.pbArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(53, 0);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(10, 27);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow.TabIndex = 4;
            this.pbArrow.TabStop = false;
            this.pbArrow.Visible = false;
            // 
            // lbTabName
            // 
            this.lbTabName.AutoSize = true;
            this.lbTabName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTabName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTabName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lbTabName.Location = new System.Drawing.Point(0, 0);
            this.lbTabName.Name = "lbTabName";
            this.lbTabName.Size = new System.Drawing.Size(53, 23);
            this.lbTabName.TabIndex = 3;
            this.lbTabName.Text = "label1";
            this.lbTabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabNavigate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.lbTabName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TabNavigate";
            this.Size = new System.Drawing.Size(78, 27);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.Label lbTabName;
    }
}
