
namespace Estant.View.FormUI.GrammarUI
{
    partial class GrammarItem
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
            this.lbLesson = new System.Windows.Forms.Label();
            this.flLessons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbLesson
            // 
            this.lbLesson.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLesson.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.lbLesson.Location = new System.Drawing.Point(0, 0);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(476, 43);
            this.lbLesson.TabIndex = 0;
            this.lbLesson.Text = "LESSON";
            this.lbLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flLessons
            // 
            this.flLessons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flLessons.Location = new System.Drawing.Point(0, 43);
            this.flLessons.Name = "flLessons";
            this.flLessons.Size = new System.Drawing.Size(476, 218);
            this.flLessons.TabIndex = 1;
            // 
            // GrammarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flLessons);
            this.Controls.Add(this.lbLesson);
            this.Name = "GrammarItem";
            this.Size = new System.Drawing.Size(476, 261);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLesson;
        private System.Windows.Forms.FlowLayoutPanel flLessons;
    }
}
