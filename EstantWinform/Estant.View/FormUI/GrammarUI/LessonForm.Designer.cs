
namespace Estant.View.FormUI.GrammarUI
{
    partial class LessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonForm));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPractice = new Estant.View.CustomControl.ButtonFlatImage();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 65);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(800, 464);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPractice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 1;
            // 
            // btnPractice
            // 
            this.btnPractice.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(11)))), ((int)(((byte)(3)))));
            this.btnPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPractice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPractice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(119)))), ((int)(((byte)(88)))));
            this.btnPractice.IconButton = ((System.Drawing.Image)(resources.GetObject("btnPractice.IconButton")));
            this.btnPractice.Location = new System.Drawing.Point(10, 10);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.btnPractice.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnPractice.Size = new System.Drawing.Size(205, 45);
            this.btnPractice.TabIndex = 2;
            this.btnPractice.TextButton = "   Practice";
            this.btnPractice.TextColor = System.Drawing.Color.White;
            this.btnPractice.Load += new System.EventHandler(this.btnPractice_Load);
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LessonForm";
            this.Text = "LessonForm";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.ButtonFlatImage btnPractice;
    }
}