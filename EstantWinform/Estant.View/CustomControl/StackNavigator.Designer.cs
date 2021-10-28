
namespace Estant.View.CustomControl
{
    partial class StackNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackNavigator));
            this.lbTab = new System.Windows.Forms.Label();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTab
            // 
            this.lbTab.AutoSize = true;
            this.lbTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTab.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.lbTab.Location = new System.Drawing.Point(20, 10);
            this.lbTab.Name = "lbTab";
            this.lbTab.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbTab.Size = new System.Drawing.Size(68, 20);
            this.lbTab.TabIndex = 0;
            this.lbTab.Text = "label1";
            this.lbTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTab.Visible = false;
            // 
            // pbArrow
            // 
            this.pbArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbArrow.Image")));
            this.pbArrow.Location = new System.Drawing.Point(88, 10);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(10, 20);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow.TabIndex = 1;
            this.pbArrow.TabStop = false;
            this.pbArrow.Visible = false;
            // 
            // StackNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.lbTab);
            this.Name = "StackNavigator";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.Size = new System.Drawing.Size(492, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTab;
        private System.Windows.Forms.PictureBox pbArrow;
    }
}
