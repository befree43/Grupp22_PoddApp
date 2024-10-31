namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lboxAvsnitt = new ListBox();
            rtbBeskrivning = new RichTextBox();
            tbURL = new TextBox();
            btnLaggTillPodcast = new Button();
            lblURL = new Label();
            lblBeskrivning = new Label();
            Prenumerationer = new Label();
            lblPodcasts = new Label();
            lblLaggTillPodcast = new Label();
            tbTitel = new TextBox();
            lblKategori = new Label();
            cboxKategori = new ComboBox();
            lblTitel = new Label();
            lblRedigeraPodcast = new Label();
            lblAvsnitt = new Label();
            lblSorteraPodcast = new Label();
            cboxSorteraPodcast = new ComboBox();
            lblValjKategori = new Label();
            btnVisaPodcast = new Button();
            lboxPodcastInomKategori = new ListBox();
            lblRedigeraKategori = new Label();
            lvPrenumerationer = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // lboxAvsnitt
            // 
            lboxAvsnitt.FormattingEnabled = true;
            lboxAvsnitt.Location = new Point(654, 67);
            lboxAvsnitt.Margin = new Padding(1, 1, 1, 1);
            lboxAvsnitt.Name = "lboxAvsnitt";
            lboxAvsnitt.Size = new Size(432, 604);
            lboxAvsnitt.TabIndex = 1;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(654, 718);
            rtbBeskrivning.Margin = new Padding(1, 1, 1, 1);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(432, 224);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(44, 442);
            tbURL.Margin = new Padding(1, 1, 1, 1);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(205, 27);
            tbURL.TabIndex = 3;
            // 
            // btnLaggTillPodcast
            // 
            btnLaggTillPodcast.Location = new Point(44, 482);
            btnLaggTillPodcast.Margin = new Padding(1, 1, 1, 1);
            btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            btnLaggTillPodcast.Size = new Size(100, 29);
            btnLaggTillPodcast.TabIndex = 4;
            btnLaggTillPodcast.Text = "Lägg till";
            btnLaggTillPodcast.UseVisualStyleBackColor = true;
            btnLaggTillPodcast.Click += btnLaggTillPodcast_Click;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(44, 420);
            lblURL.Margin = new Padding(1, 0, 1, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(35, 20);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(654, 696);
            lblBeskrivning.Margin = new Padding(1, 0, 1, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(84, 20);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(44, 45);
            Prenumerationer.Margin = new Padding(1, 0, 1, 0);
            Prenumerationer.Name = "Prenumerationer";
            Prenumerationer.Size = new Size(119, 20);
            Prenumerationer.TabIndex = 9;
            Prenumerationer.Text = "Prenumerationer";
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPodcasts.Location = new Point(36, 0);
            lblPodcasts.Margin = new Padding(1, 0, 1, 0);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(135, 41);
            lblPodcasts.TabIndex = 10;
            lblPodcasts.Text = "Podcasts";
            // 
            // lblLaggTillPodcast
            // 
            lblLaggTillPodcast.AutoSize = true;
            lblLaggTillPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaggTillPodcast.Location = new Point(44, 269);
            lblLaggTillPodcast.Margin = new Padding(1, 0, 1, 0);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(157, 28);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(44, 331);
            tbTitel.Margin = new Padding(1, 1, 1, 1);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(205, 27);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(44, 364);
            lblKategori.Margin = new Padding(1, 0, 1, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(44, 387);
            cboxKategori.Margin = new Padding(1, 1, 1, 1);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(205, 28);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(44, 309);
            lblTitel.Margin = new Padding(1, 0, 1, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(49, 20);
            lblTitel.TabIndex = 16;
            lblTitel.Text = "Namn";
            // 
            // lblRedigeraPodcast
            // 
            lblRedigeraPodcast.AutoSize = true;
            lblRedigeraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraPodcast.Location = new Point(300, 269);
            lblRedigeraPodcast.Margin = new Padding(1, 0, 1, 0);
            lblRedigeraPodcast.Name = "lblRedigeraPodcast";
            lblRedigeraPodcast.Size = new Size(164, 28);
            lblRedigeraPodcast.TabIndex = 18;
            lblRedigeraPodcast.Text = "Redigera podcast";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(654, 42);
            lblAvsnitt.Margin = new Padding(1, 0, 1, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(54, 20);
            lblAvsnitt.TabIndex = 19;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblSorteraPodcast
            // 
            lblSorteraPodcast.AutoSize = true;
            lblSorteraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSorteraPodcast.Location = new Point(44, 556);
            lblSorteraPodcast.Margin = new Padding(1, 0, 1, 0);
            lblSorteraPodcast.Name = "lblSorteraPodcast";
            lblSorteraPodcast.Size = new Size(151, 28);
            lblSorteraPodcast.TabIndex = 20;
            lblSorteraPodcast.Text = "Sortera podcast";
            // 
            // cboxSorteraPodcast
            // 
            cboxSorteraPodcast.FormattingEnabled = true;
            cboxSorteraPodcast.Location = new Point(44, 619);
            cboxSorteraPodcast.Margin = new Padding(1, 1, 1, 1);
            cboxSorteraPodcast.Name = "cboxSorteraPodcast";
            cboxSorteraPodcast.Size = new Size(205, 28);
            cboxSorteraPodcast.TabIndex = 21;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(44, 599);
            lblValjKategori.Margin = new Padding(1, 0, 1, 0);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(92, 20);
            lblValjKategori.TabIndex = 22;
            lblValjKategori.Text = "Välj kategori";
            // 
            // btnVisaPodcast
            // 
            btnVisaPodcast.Location = new Point(44, 664);
            btnVisaPodcast.Margin = new Padding(1, 1, 1, 1);
            btnVisaPodcast.Name = "btnVisaPodcast";
            btnVisaPodcast.Size = new Size(100, 29);
            btnVisaPodcast.TabIndex = 23;
            btnVisaPodcast.Text = "Visa podcast";
            btnVisaPodcast.UseVisualStyleBackColor = true;
            // 
            // lboxPodcastInomKategori
            // 
            lboxPodcastInomKategori.FormattingEnabled = true;
            lboxPodcastInomKategori.Location = new Point(44, 718);
            lboxPodcastInomKategori.Margin = new Padding(1, 1, 1, 1);
            lboxPodcastInomKategori.Name = "lboxPodcastInomKategori";
            lboxPodcastInomKategori.Size = new Size(555, 224);
            lboxPodcastInomKategori.TabIndex = 24;
            // 
            // lblRedigeraKategori
            // 
            lblRedigeraKategori.AutoSize = true;
            lblRedigeraKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraKategori.Location = new Point(300, 556);
            lblRedigeraKategori.Margin = new Padding(1, 0, 1, 0);
            lblRedigeraKategori.Name = "lblRedigeraKategori";
            lblRedigeraKategori.Size = new Size(167, 28);
            lblRedigeraKategori.TabIndex = 25;
            lblRedigeraKategori.Text = "Redigera kategori";
            // 
            // lvPrenumerationer
            // 
            lvPrenumerationer.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvPrenumerationer.FullRowSelect = true;
            lvPrenumerationer.Location = new Point(44, 67);
            lvPrenumerationer.Margin = new Padding(4, 4, 4, 4);
            lvPrenumerationer.MultiSelect = false;
            lvPrenumerationer.Name = "lvPrenumerationer";
            lvPrenumerationer.Size = new Size(555, 183);
            lvPrenumerationer.TabIndex = 26;
            lvPrenumerationer.UseCompatibleStateImageBehavior = false;
            lvPrenumerationer.View = View.Details;
            lvPrenumerationer.SelectedIndexChanged += lvPrenumerationer_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Titel";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            columnHeader3.Width = 90;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 595);
            Controls.Add(lvPrenumerationer);
            Controls.Add(lblRedigeraKategori);
            Controls.Add(lboxPodcastInomKategori);
            Controls.Add(btnVisaPodcast);
            Controls.Add(lblValjKategori);
            Controls.Add(cboxSorteraPodcast);
            Controls.Add(lblSorteraPodcast);
            Controls.Add(lblAvsnitt);
            Controls.Add(lblRedigeraPodcast);
            Controls.Add(lblTitel);
            Controls.Add(cboxKategori);
            Controls.Add(lblKategori);
            Controls.Add(tbTitel);
            Controls.Add(lblLaggTillPodcast);
            Controls.Add(lblPodcasts);
            Controls.Add(Prenumerationer);
            Controls.Add(lblBeskrivning);
            Controls.Add(lblURL);
            Controls.Add(btnLaggTillPodcast);
            Controls.Add(tbURL);
            Controls.Add(rtbBeskrivning);
            Controls.Add(lboxAvsnitt);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lboxAvsnitt;
        private RichTextBox rtbBeskrivning;
        private TextBox tbURL;
        private Button btnLaggTill;
        private Label lblRedigeraPodcast;
        private Label lblURL;
        private Label lblBeskrivning;
        private Label Prenumerationer;
        private Label lblPodcasts;
        private Label lblLaggTillPodcast;
        private TextBox tbTitel;
        private Label lblKategori;
        private ComboBox cboxKategori;
        private Label lblTitel;
        private Label lblAvsnitt;
        private Label lblSorteraPodcast;
        private ComboBox cboxSorteraPodcast;
        private Label lblValjKategori;
        private Button btnVisaPodcast;
        private ListBox lboxPodcastInomKategori;
        private Label lblRedigeraKategori;
        private Button btnLaggTillPodcast;
        private ListView lvPrenumerationer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
