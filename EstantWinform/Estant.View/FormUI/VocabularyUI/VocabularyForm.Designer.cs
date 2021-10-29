
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchBar1 = new Estant.View.CustomControl.SearchBar();
            this.buttonFlatImage2 = new Estant.View.CustomControl.ButtonFlatImage();
            this.buttonFlatImage1 = new Estant.View.CustomControl.ButtonFlatImage();
            this.stNavigate = new Estant.View.CustomControl.StackNavigator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 579);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.searchBar1);
            this.tabPage1.Controls.Add(this.buttonFlatImage2);
            this.tabPage1.Controls.Add(this.buttonFlatImage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.White;
            this.searchBar1.Hint = "Search new word here";
            this.searchBar1.Location = new System.Drawing.Point(488, 5);
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
            this.buttonFlatImage2.Location = new System.Drawing.Point(241, 2);
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
            this.buttonFlatImage1.Location = new System.Drawing.Point(30, 3);
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
            this.stNavigate.Size = new System.Drawing.Size(834, 50);
            this.stNavigate.tabControl = null;
            this.stNavigate.TabIndex = 2;
            // 
            // VocabularyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 629);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stNavigate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VocabularyForm";
            this.Text = "VocabularyForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CustomControl.ButtonFlatImage buttonFlatImage1;
        private CustomControl.ButtonFlatImage buttonFlatImage2;
        private CustomControl.SearchBar searchBar1;
        private CustomControl.StackNavigator stNavigate;
    }
}