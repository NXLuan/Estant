
namespace Estant.View.FormUI.ListenUI
{
    partial class ListenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListenForm));
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.lbShowPodcastsHome = new System.Windows.Forms.Label();
            this.lbTypePodcast = new System.Windows.Forms.Label();
            this.pnEmpty = new System.Windows.Forms.Panel();
            this.flListListen = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBar = new Estant.View.CustomControl.SearchBar();
            this.stackNavigator = new Estant.View.CustomControl.StackNavigator();
            this.tabForm.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.pnEmpty.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabForm.Size = new System.Drawing.Size(880, 566);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 3;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage.Controls.Add(this.lbShowPodcastsHome);
            this.tabPage.Controls.Add(this.lbTypePodcast);
            this.tabPage.Controls.Add(this.pnEmpty);
            this.tabPage.Controls.Add(this.searchBar);
            this.tabPage.Location = new System.Drawing.Point(4, 5);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(872, 557);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPage1";
            // 
            // lbShowPodcastsHome
            // 
            this.lbShowPodcastsHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShowPodcastsHome.AutoSize = true;
            this.lbShowPodcastsHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbShowPodcastsHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowPodcastsHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.lbShowPodcastsHome.Location = new System.Drawing.Point(692, 67);
            this.lbShowPodcastsHome.Name = "lbShowPodcastsHome";
            this.lbShowPodcastsHome.Size = new System.Drawing.Size(152, 20);
            this.lbShowPodcastsHome.TabIndex = 19;
            this.lbShowPodcastsHome.Text = "Show podcasts home";
            this.lbShowPodcastsHome.Click += new System.EventHandler(this.lbShowPodcastsHome_Click);
            // 
            // lbTypePodcast
            // 
            this.lbTypePodcast.AutoSize = true;
            this.lbTypePodcast.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypePodcast.ForeColor = System.Drawing.Color.Gray;
            this.lbTypePodcast.Location = new System.Drawing.Point(22, 64);
            this.lbTypePodcast.Name = "lbTypePodcast";
            this.lbTypePodcast.Size = new System.Drawing.Size(94, 23);
            this.lbTypePodcast.TabIndex = 18;
            this.lbTypePodcast.Text = "PODCASTS";
            // 
            // pnEmpty
            // 
            this.pnEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnEmpty.Controls.Add(this.flListListen);
            this.pnEmpty.Controls.Add(this.panel1);
            this.pnEmpty.Location = new System.Drawing.Point(0, 90);
            this.pnEmpty.Name = "pnEmpty";
            this.pnEmpty.Size = new System.Drawing.Size(869, 464);
            this.pnEmpty.TabIndex = 17;
            // 
            // flListListen
            // 
            this.flListListen.AutoScroll = true;
            this.flListListen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flListListen.Location = new System.Drawing.Point(0, 0);
            this.flListListen.Name = "flListListen";
            this.flListListen.Padding = new System.Windows.Forms.Padding(15, 10, 10, 0);
            this.flListListen.Size = new System.Drawing.Size(869, 464);
            this.flListListen.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(303, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 127);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "NO RESULTS FOUND";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.Hint = "Search podcast";
            this.searchBar.Location = new System.Drawing.Point(26, 6);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(339, 44);
            this.searchBar.TabIndex = 1;
            this.searchBar.Search += new System.EventHandler(this.searchBar_Search);
            // 
            // stackNavigator
            // 
            this.stackNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.stackNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.stackNavigator.Location = new System.Drawing.Point(0, 0);
            this.stackNavigator.Name = "stackNavigator";
            this.stackNavigator.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.stackNavigator.Size = new System.Drawing.Size(880, 46);
            this.stackNavigator.tabControl = null;
            this.stackNavigator.TabIndex = 1;
            // 
            // ListenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 612);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.stackNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListenForm";
            this.Text = "ListenForm";
            this.tabForm.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.pnEmpty.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.StackNavigator stackNavigator;
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabPage;
        private CustomControl.SearchBar searchBar;
        private System.Windows.Forms.Panel pnEmpty;
        private System.Windows.Forms.FlowLayoutPanel flListListen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTypePodcast;
        private System.Windows.Forms.Label lbShowPodcastsHome;
    }
}