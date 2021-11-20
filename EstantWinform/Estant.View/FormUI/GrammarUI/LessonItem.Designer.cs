
namespace Estant.View.FormUI.GrammarUI
{
    partial class LessonItem
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
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbGrammar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIndex
            // 
            this.lbIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.lbIndex.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.ForeColor = System.Drawing.Color.White;
            this.lbIndex.Location = new System.Drawing.Point(0, 0);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(46, 48);
            this.lbIndex.TabIndex = 0;
            this.lbIndex.Text = "1";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGrammar
            // 
            this.lbGrammar.BackColor = System.Drawing.Color.White;
            this.lbGrammar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGrammar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrammar.Location = new System.Drawing.Point(46, 0);
            this.lbGrammar.Name = "lbGrammar";
            this.lbGrammar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbGrammar.Size = new System.Drawing.Size(346, 48);
            this.lbGrammar.TabIndex = 1;
            this.lbGrammar.Text = "grammar";
            this.lbGrammar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LessonItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbGrammar);
            this.Controls.Add(this.lbIndex);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "LessonItem";
            this.Size = new System.Drawing.Size(392, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label lbGrammar;
    }
}
