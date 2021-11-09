
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
            this.flTab = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flTab
            // 
            this.flTab.BackColor = System.Drawing.SystemColors.Control;
            this.flTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flTab.Location = new System.Drawing.Point(20, 10);
            this.flTab.Name = "flTab";
            this.flTab.Size = new System.Drawing.Size(472, 43);
            this.flTab.TabIndex = 0;
            // 
            // StackNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flTab);
            this.Name = "StackNavigator";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.Size = new System.Drawing.Size(492, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flTab;
    }
}
