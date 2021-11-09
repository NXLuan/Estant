
namespace Estant.View.FormUI.VocabularyUI
{
    partial class VocabularyForm
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
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableTopic = new System.Windows.Forms.FlowLayoutPanel();
            this.pnLoad = new Estant.View.CustomControl.LoadCircle();
            this.searchBar1 = new Estant.View.CustomControl.SearchBar();
            this.stNavigate = new Estant.View.CustomControl.StackNavigator();
            this.label2 = new System.Windows.Forms.Label();
            this.flSaveWords = new System.Windows.Forms.FlowLayoutPanel();
            this.tabForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabForm.Controls.Add(this.tabPage1);
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForm.ItemSize = new System.Drawing.Size(0, 1);
            this.tabForm.Location = new System.Drawing.Point(0, 55);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(843, 574);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.searchBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.flSaveWords);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableTopic);
            this.panel1.Controls.Add(this.pnLoad);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 507);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOPICS";
            // 
            // tableTopic
            // 
            this.tableTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTopic.Location = new System.Drawing.Point(0, 236);
            this.tableTopic.Name = "tableTopic";
            this.tableTopic.Size = new System.Drawing.Size(829, 271);
            this.tableTopic.TabIndex = 5;
            // 
            // pnLoad
            // 
            this.pnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoad.Location = new System.Drawing.Point(0, 0);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(829, 507);
            this.pnLoad.TabIndex = 7;
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar1.BackColor = System.Drawing.Color.White;
            this.searchBar1.Hint = "Search new word here";
            this.searchBar1.Location = new System.Drawing.Point(25, 5);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(315, 44);
            this.searchBar1.TabIndex = 2;
            // 
            // stNavigate
            // 
            this.stNavigate.BackColor = System.Drawing.SystemColors.Control;
            this.stNavigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.stNavigate.Location = new System.Drawing.Point(0, 0);
            this.stNavigate.Name = "stNavigate";
            this.stNavigate.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.stNavigate.Size = new System.Drawing.Size(843, 55);
            this.stNavigate.tabControl = null;
            this.stNavigate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "SAVED WORDS";
            // 
            // flSaveWords
            // 
            this.flSaveWords.Location = new System.Drawing.Point(-3, 42);
            this.flSaveWords.Name = "flSaveWords";
            this.flSaveWords.Size = new System.Drawing.Size(835, 158);
            this.flSaveWords.TabIndex = 10;
            // 
            // VocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 629);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.stNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VocabularyForm";
            this.Text = "VocabularyForm";
            this.tabForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabPage1;
        private CustomControl.SearchBar searchBar1;
        private CustomControl.StackNavigator stNavigate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tableTopic;
        private CustomControl.LoadCircle pnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flSaveWords;
    }
}