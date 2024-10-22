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
            tbNamn = new TextBox();
            btnLaggTill = new Button();
            dgvPrenumerationer = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvPrenumerationer).BeginInit();
            SuspendLayout();
            // 
            // lboxAvsnitt
            // 
            lboxAvsnitt.FormattingEnabled = true;
            lboxAvsnitt.ItemHeight = 15;
            lboxAvsnitt.Location = new Point(572, 50);
            lboxAvsnitt.Margin = new Padding(1, 1, 1, 1);
            lboxAvsnitt.Name = "lboxAvsnitt";
            lboxAvsnitt.Size = new Size(379, 454);
            lboxAvsnitt.TabIndex = 1;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(572, 538);
            rtbBeskrivning.Margin = new Padding(1, 1, 1, 1);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(379, 169);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(38, 332);
            tbNamn.Margin = new Padding(1, 1, 1, 1);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(180, 23);
            tbNamn.TabIndex = 3;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(38, 362);
            btnLaggTill.Margin = new Padding(1, 1, 1, 1);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(88, 22);
            btnLaggTill.TabIndex = 4;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // dgvPrenumerationer
            // 
            dgvPrenumerationer.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPrenumerationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrenumerationer.GridColor = SystemColors.GradientInactiveCaption;
            dgvPrenumerationer.Location = new Point(38, 50);
            dgvPrenumerationer.Margin = new Padding(1, 1, 1, 1);
            dgvPrenumerationer.Name = "dgvPrenumerationer";
            dgvPrenumerationer.RowHeadersWidth = 123;
            dgvPrenumerationer.Size = new Size(486, 141);
            dgvPrenumerationer.TabIndex = 5;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(38, 315);
            lblURL.Margin = new Padding(1, 0, 1, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(28, 15);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(572, 522);
            lblBeskrivning.Margin = new Padding(1, 0, 1, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(68, 15);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(38, 34);
            Prenumerationer.Margin = new Padding(1, 0, 1, 0);
            Prenumerationer.Name = "Prenumerationer";
            Prenumerationer.Size = new Size(96, 15);
            Prenumerationer.TabIndex = 9;
            Prenumerationer.Text = "Prenumerationer";
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPodcasts.Location = new Point(32, 0);
            lblPodcasts.Margin = new Padding(1, 0, 1, 0);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(105, 32);
            lblPodcasts.TabIndex = 10;
            lblPodcasts.Text = "Podcasts";
            // 
            // lblLaggTillPodcast
            // 
            lblLaggTillPodcast.AutoSize = true;
            lblLaggTillPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaggTillPodcast.Location = new Point(38, 202);
            lblLaggTillPodcast.Margin = new Padding(1, 0, 1, 0);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(123, 21);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(38, 248);
            tbTitel.Margin = new Padding(1, 1, 1, 1);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(180, 23);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(38, 273);
            lblKategori.Margin = new Padding(1, 0, 1, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(38, 289);
            cboxKategori.Margin = new Padding(1, 1, 1, 1);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(180, 23);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(38, 232);
            lblTitel.Margin = new Padding(1, 0, 1, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(40, 15);
            lblTitel.TabIndex = 16;
            lblTitel.Text = "Namn";
            // 
            // lblRedigeraPodcast
            // 
            lblRedigeraPodcast.AutoSize = true;
            lblRedigeraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraPodcast.Location = new Point(262, 202);
            lblRedigeraPodcast.Margin = new Padding(1, 0, 1, 0);
            lblRedigeraPodcast.Name = "lblRedigeraPodcast";
            lblRedigeraPodcast.Size = new Size(130, 21);
            lblRedigeraPodcast.TabIndex = 18;
            lblRedigeraPodcast.Text = "Redigera podcast";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(572, 32);
            lblAvsnitt.Margin = new Padding(1, 0, 1, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(44, 15);
            lblAvsnitt.TabIndex = 19;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblSorteraPodcast
            // 
            lblSorteraPodcast.AutoSize = true;
            lblSorteraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSorteraPodcast.Location = new Point(38, 417);
            lblSorteraPodcast.Margin = new Padding(1, 0, 1, 0);
            lblSorteraPodcast.Name = "lblSorteraPodcast";
            lblSorteraPodcast.Size = new Size(119, 21);
            lblSorteraPodcast.TabIndex = 20;
            lblSorteraPodcast.Text = "Sortera podcast";
            // 
            // cboxSorteraPodcast
            // 
            cboxSorteraPodcast.FormattingEnabled = true;
            cboxSorteraPodcast.Location = new Point(38, 464);
            cboxSorteraPodcast.Margin = new Padding(1, 1, 1, 1);
            cboxSorteraPodcast.Name = "cboxSorteraPodcast";
            cboxSorteraPodcast.Size = new Size(180, 23);
            cboxSorteraPodcast.TabIndex = 21;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(38, 449);
            lblValjKategori.Margin = new Padding(1, 0, 1, 0);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(71, 15);
            lblValjKategori.TabIndex = 22;
            lblValjKategori.Text = "Välj kategori";
            // 
            // btnVisaPodcast
            // 
            btnVisaPodcast.Location = new Point(38, 498);
            btnVisaPodcast.Margin = new Padding(1, 1, 1, 1);
            btnVisaPodcast.Name = "btnVisaPodcast";
            btnVisaPodcast.Size = new Size(88, 22);
            btnVisaPodcast.TabIndex = 23;
            btnVisaPodcast.Text = "Visa podcast";
            btnVisaPodcast.UseVisualStyleBackColor = true;
            // 
            // lboxPodcastInomKategori
            // 
            lboxPodcastInomKategori.FormattingEnabled = true;
            lboxPodcastInomKategori.ItemHeight = 15;
            lboxPodcastInomKategori.Location = new Point(38, 538);
            lboxPodcastInomKategori.Margin = new Padding(1, 1, 1, 1);
            lboxPodcastInomKategori.Name = "lboxPodcastInomKategori";
            lboxPodcastInomKategori.Size = new Size(486, 169);
            lboxPodcastInomKategori.TabIndex = 24;
            // 
            // lblRedigeraKategori
            // 
            lblRedigeraKategori.AutoSize = true;
            lblRedigeraKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraKategori.Location = new Point(262, 417);
            lblRedigeraKategori.Margin = new Padding(1, 0, 1, 0);
            lblRedigeraKategori.Name = "lblRedigeraKategori";
            lblRedigeraKategori.Size = new Size(133, 21);
            lblRedigeraKategori.TabIndex = 25;
            lblRedigeraKategori.Text = "Redigera kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 736);
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
            Controls.Add(dgvPrenumerationer);
            Controls.Add(btnLaggTill);
            Controls.Add(tbNamn);
            Controls.Add(rtbBeskrivning);
            Controls.Add(lboxAvsnitt);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPrenumerationer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lboxAvsnitt;
        private RichTextBox rtbBeskrivning;
        private TextBox tbNamn;
        private Button btnLaggTill;
        private DataGridView dgvPrenumerationer;
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
    }
}
