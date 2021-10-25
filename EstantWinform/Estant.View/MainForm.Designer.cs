
namespace Estant.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVocab = new Estant.View.CustomControl.ButtonImage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGrammar = new Estant.View.CustomControl.ButtonImage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGrammar);
            this.panel1.Controls.Add(this.btnVocab);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 633);
            this.panel1.TabIndex = 0;
            // 
            // btnVocab
            // 
            this.btnVocab.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnVocab.ActiveImage")));
            this.btnVocab.BackColor = System.Drawing.Color.White;
            this.btnVocab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVocab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVocab.IsActive = false;
            this.btnVocab.Location = new System.Drawing.Point(0, 70);
            this.btnVocab.Name = "btnVocab";
            this.btnVocab.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnVocab.NormalImage")));
            this.btnVocab.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.btnVocab.Size = new System.Drawing.Size(232, 55);
            this.btnVocab.TabIndex = 1;
            this.btnVocab.TextButton = "Vocabulary";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 5, 10, 5);
            this.panel2.Size = new System.Drawing.Size(232, 70);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(86, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(136, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGrammar
            // 
            this.btnGrammar.ActiveImage = ((System.Drawing.Image)(resources.GetObject("btnGrammar.ActiveImage")));
            this.btnGrammar.BackColor = System.Drawing.Color.White;
            this.btnGrammar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrammar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrammar.IsActive = false;
            this.btnGrammar.Location = new System.Drawing.Point(0, 125);
            this.btnGrammar.Name = "btnGrammar";
            this.btnGrammar.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnGrammar.NormalImage")));
            this.btnGrammar.Padding = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.btnGrammar.Size = new System.Drawing.Size(232, 55);
            this.btnGrammar.TabIndex = 2;
            this.btnGrammar.TextButton = "Grammar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 633);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControl.ButtonImage btnVocab;
        private CustomControl.ButtonImage btnGrammar;
    }
}

