
namespace Estant.View.FormUI.NewsUI
{
    partial class NewsForm
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
            this.tabPage = new System.Windows.Forms.TabPage();
            this.flListNews = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBar1 = new Estant.View.CustomControl.SearchBar();
            this.stackNavigator = new Estant.View.CustomControl.StackNavigator();
            this.tabForm.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabForm.Controls.Add(this.tabPage);
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForm.ItemSize = new System.Drawing.Size(0, 1);
            this.tabForm.Location = new System.Drawing.Point(0, 46);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(843, 583);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 3;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage.Controls.Add(this.flListNews);
            this.tabPage.Controls.Add(this.label2);
            this.tabPage.Controls.Add(this.searchBar1);
            this.tabPage.Location = new System.Drawing.Point(4, 5);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(835, 574);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPage1";
            // 
            // flListNews
            // 
            this.flListNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flListNews.AutoScroll = true;
            this.flListNews.Location = new System.Drawing.Point(0, 107);
            this.flListNews.Name = "flListNews";
            this.flListNews.Padding = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.flListNews.Size = new System.Drawing.Size(832, 467);
            this.flListNews.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "NEWS";
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.White;
            this.searchBar1.Hint = "Enter keyword";
            this.searchBar1.Location = new System.Drawing.Point(24, 16);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(339, 42);
            this.searchBar1.TabIndex = 0;
            // 
            // stackNavigator
            // 
            this.stackNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.stackNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackNavigator.Location = new System.Drawing.Point(0, 0);
            this.stackNavigator.Name = "stackNavigator";
            this.stackNavigator.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.stackNavigator.Size = new System.Drawing.Size(843, 46);
            this.stackNavigator.tabControl = null;
            this.stackNavigator.TabIndex = 1;
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 629);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.stackNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewsForm";
            this.Text = "NewsForm";
            this.tabForm.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.StackNavigator stackNavigator;
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabPage;
        private CustomControl.SearchBar searchBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flListNews;
    }
}