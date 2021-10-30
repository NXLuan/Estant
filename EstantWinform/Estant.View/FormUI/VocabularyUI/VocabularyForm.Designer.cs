
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
            this.searchBar1 = new Estant.View.CustomControl.SearchBar();
            this.buttonFlatImage2 = new Estant.View.CustomControl.ButtonFlatImage();
            this.buttonFlatImage1 = new Estant.View.CustomControl.ButtonFlatImage();
            this.stNavigate = new Estant.View.CustomControl.StackNavigator();
            this.pnLoad = new Estant.View.CustomControl.LoadCircle();
            this.tableTopic = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabForm.Location = new System.Drawing.Point(0, 56);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(843, 573);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.searchBar1);
            this.tabPage1.Controls.Add(this.buttonFlatImage2);
            this.tabPage1.Controls.Add(this.buttonFlatImage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar1.BackColor = System.Drawing.Color.White;
            this.searchBar1.Hint = "Search new word here";
            this.searchBar1.Location = new System.Drawing.Point(488, 4);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(315, 44);
            this.searchBar1.TabIndex = 2;
            // 
            // buttonFlatImage2
            // 
            this.buttonFlatImage2.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(123)))));
            this.buttonFlatImage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.buttonFlatImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlatImage2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(114)))), ((int)(((byte)(221)))));
            this.buttonFlatImage2.IconButton = ((System.Drawing.Image)(resources.GetObject("buttonFlatImage2.IconButton")));
            this.buttonFlatImage2.Location = new System.Drawing.Point(236, 3);
            this.buttonFlatImage2.Name = "buttonFlatImage2";
            this.buttonFlatImage2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.buttonFlatImage2.Padding = new System.Windows.Forms.Padding(10);
            this.buttonFlatImage2.Size = new System.Drawing.Size(231, 46);
            this.buttonFlatImage2.TabIndex = 1;
            this.buttonFlatImage2.TextButton = "Searched words";
            this.buttonFlatImage2.TextColor = System.Drawing.Color.White;
            // 
            // buttonFlatImage1
            // 
            this.buttonFlatImage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(38)))), ((int)(((byte)(0)))));
            this.buttonFlatImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.buttonFlatImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlatImage1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(46)))));
            this.buttonFlatImage1.IconButton = ((System.Drawing.Image)(resources.GetObject("buttonFlatImage1.IconButton")));
            this.buttonFlatImage1.Location = new System.Drawing.Point(21, 3);
            this.buttonFlatImage1.Name = "buttonFlatImage1";
            this.buttonFlatImage1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(0)))));
            this.buttonFlatImage1.Padding = new System.Windows.Forms.Padding(10);
            this.buttonFlatImage1.Size = new System.Drawing.Size(196, 46);
            this.buttonFlatImage1.TabIndex = 0;
            this.buttonFlatImage1.TextButton = "Saved words";
            this.buttonFlatImage1.TextColor = System.Drawing.Color.White;
            // 
            // stNavigate
            // 
            this.stNavigate.BackColor = System.Drawing.SystemColors.Control;
            this.stNavigate.Dock = System.Windows.Forms.DockStyle.Top;
            this.stNavigate.Location = new System.Drawing.Point(0, 0);
            this.stNavigate.Name = "stNavigate";
            this.stNavigate.Padding = new System.Windows.Forms.Padding(20, 20, 0, 10);
            this.stNavigate.Size = new System.Drawing.Size(843, 56);
            this.stNavigate.tabControl = null;
            this.stNavigate.TabIndex = 2;
            // 
            // pnLoad
            // 
            this.pnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLoad.Location = new System.Drawing.Point(0, 0);
            this.pnLoad.Name = "pnLoad";
            this.pnLoad.Size = new System.Drawing.Size(829, 506);
            this.pnLoad.TabIndex = 7;
            // 
            // tableTopic
            // 
            this.tableTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTopic.Location = new System.Drawing.Point(0, 56);
            this.tableTopic.Name = "tableTopic";
            this.tableTopic.Size = new System.Drawing.Size(829, 450);
            this.tableTopic.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableTopic);
            this.panel1.Controls.Add(this.pnLoad);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 506);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "TOPICS";
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
        private CustomControl.ButtonFlatImage buttonFlatImage1;
        private CustomControl.ButtonFlatImage buttonFlatImage2;
        private CustomControl.SearchBar searchBar1;
        private CustomControl.StackNavigator stNavigate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel tableTopic;
        private CustomControl.LoadCircle pnLoad;
        private System.Windows.Forms.Label label1;
    }
}