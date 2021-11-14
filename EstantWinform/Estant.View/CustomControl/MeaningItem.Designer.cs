
namespace Estant.View.CustomControl
{
    partial class MeaningItem
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
            this.pnDivide = new System.Windows.Forms.Panel();
            this.lbPartOfSpeech = new System.Windows.Forms.Label();
            this.pnDefinition = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnDivide
            // 
            this.pnDivide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnDivide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDivide.Location = new System.Drawing.Point(0, 0);
            this.pnDivide.Name = "pnDivide";
            this.pnDivide.Size = new System.Drawing.Size(639, 2);
            this.pnDivide.TabIndex = 0;
            // 
            // lbPartOfSpeech
            // 
            this.lbPartOfSpeech.AutoSize = true;
            this.lbPartOfSpeech.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPartOfSpeech.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPartOfSpeech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.lbPartOfSpeech.Location = new System.Drawing.Point(0, 2);
            this.lbPartOfSpeech.Name = "lbPartOfSpeech";
            this.lbPartOfSpeech.Padding = new System.Windows.Forms.Padding(30, 10, 0, 0);
            this.lbPartOfSpeech.Size = new System.Drawing.Size(145, 33);
            this.lbPartOfSpeech.TabIndex = 1;
            this.lbPartOfSpeech.Text = "PartOfSpeech";
            // 
            // pnDefinition
            // 
            this.pnDefinition.AutoSize = true;
            this.pnDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDefinition.Location = new System.Drawing.Point(0, 35);
            this.pnDefinition.Name = "pnDefinition";
            this.pnDefinition.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.pnDefinition.Size = new System.Drawing.Size(639, 318);
            this.pnDefinition.TabIndex = 2;
            // 
            // MeaningItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnDefinition);
            this.Controls.Add(this.lbPartOfSpeech);
            this.Controls.Add(this.pnDivide);
            this.Name = "MeaningItem";
            this.Size = new System.Drawing.Size(639, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDivide;
        private System.Windows.Forms.Label lbPartOfSpeech;
        private System.Windows.Forms.Panel pnDefinition;
    }
}
