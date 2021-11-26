
namespace Estant.View.FormUI.GrammarUI
{
    partial class ResultCheckGrammarPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultCheckGrammarPopup));
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabCorrect = new System.Windows.Forms.TabPage();
            this.tabError = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCorrectSentence = new System.Windows.Forms.Label();
            this.pnListWrong = new System.Windows.Forms.Panel();
            this.tabForm.SuspendLayout();
            this.tabCorrect.SuspendLayout();
            this.tabError.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabForm.Controls.Add(this.tabCorrect);
            this.tabForm.Controls.Add(this.tabError);
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForm.ItemSize = new System.Drawing.Size(0, 1);
            this.tabForm.Location = new System.Drawing.Point(0, 0);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(462, 292);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 3;
            // 
            // tabCorrect
            // 
            this.tabCorrect.BackColor = System.Drawing.SystemColors.Control;
            this.tabCorrect.Controls.Add(this.label1);
            this.tabCorrect.Location = new System.Drawing.Point(4, 5);
            this.tabCorrect.Name = "tabCorrect";
            this.tabCorrect.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorrect.Size = new System.Drawing.Size(454, 326);
            this.tabCorrect.TabIndex = 0;
            this.tabCorrect.Text = "tabPage1";
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.lbCorrectSentence);
            this.tabError.Controls.Add(this.label3);
            this.tabError.Controls.Add(this.pnListWrong);
            this.tabError.Controls.Add(this.label2);
            this.tabError.Location = new System.Drawing.Point(4, 5);
            this.tabError.Name = "tabError";
            this.tabError.Size = new System.Drawing.Size(454, 283);
            this.tabError.TabIndex = 1;
            this.tabError.Text = "tabPage1";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 320);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR SENTENCE IS CORRECT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "YOUR SENTENCE IS WRONG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(136)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "CORRECT SENTENCE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCorrectSentence
            // 
            this.lbCorrectSentence.AutoSize = true;
            this.lbCorrectSentence.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCorrectSentence.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectSentence.ForeColor = System.Drawing.Color.Black;
            this.lbCorrectSentence.Location = new System.Drawing.Point(0, 108);
            this.lbCorrectSentence.MaximumSize = new System.Drawing.Size(420, 0);
            this.lbCorrectSentence.Name = "lbCorrectSentence";
            this.lbCorrectSentence.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbCorrectSentence.Size = new System.Drawing.Size(192, 23);
            this.lbCorrectSentence.TabIndex = 3;
            this.lbCorrectSentence.Text = "CORRECT SENTENCE";
            this.lbCorrectSentence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnListWrong
            // 
            this.pnListWrong.AutoSize = true;
            this.pnListWrong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnListWrong.Location = new System.Drawing.Point(0, 55);
            this.pnListWrong.Name = "pnListWrong";
            this.pnListWrong.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnListWrong.Size = new System.Drawing.Size(454, 0);
            this.pnListWrong.TabIndex = 4;
            // 
            // ResultCheckGrammarPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(462, 292);
            this.Controls.Add(this.tabForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultCheckGrammarPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result check spell and grammar";
            this.tabForm.ResumeLayout(false);
            this.tabCorrect.ResumeLayout(false);
            this.tabError.ResumeLayout(false);
            this.tabError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabCorrect;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCorrectSentence;
        private System.Windows.Forms.Panel pnListWrong;
    }
}