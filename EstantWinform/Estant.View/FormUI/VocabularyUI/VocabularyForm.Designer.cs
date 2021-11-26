
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabularyForm));
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableTopic = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flSaveWords = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBar = new Estant.View.CustomControl.SearchBar();
            this.stNavigate = new Estant.View.CustomControl.StackNavigator();
            this.tabForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.searchBar);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableTopic);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 489);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "SAVED WORDS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOPICS";
            // 
            // tableTopic
            // 
            this.tableTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTopic.Location = new System.Drawing.Point(0, 228);
            this.tableTopic.Name = "tableTopic";
            this.tableTopic.Size = new System.Drawing.Size(829, 253);
            this.tableTopic.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flSaveWords);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 158);
            this.panel2.TabIndex = 15;
            // 
            // flSaveWords
            // 
            this.flSaveWords.AutoScroll = true;
            this.flSaveWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flSaveWords.Location = new System.Drawing.Point(0, 0);
            this.flSaveWords.Name = "flSaveWords";
            this.flSaveWords.Padding = new System.Windows.Forms.Padding(10);
            this.flSaveWords.Size = new System.Drawing.Size(826, 158);
            this.flSaveWords.TabIndex = 15;
            this.flSaveWords.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(275, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 83);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(0, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "You haven\'t saved any words";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.Hint = "Search new word here";
            this.searchBar.Location = new System.Drawing.Point(25, 5);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(315, 44);
            this.searchBar.TabIndex = 2;
            this.searchBar.Search += new System.EventHandler(this.searchBar_Search);
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
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabPage1;
        private CustomControl.SearchBar searchBar;
        private CustomControl.StackNavigator stNavigate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel tableTopic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flSaveWords;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}