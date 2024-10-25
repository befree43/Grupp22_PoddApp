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
            lboxAvsnitt.Location = new Point(1062, 107);
            lboxAvsnitt.Margin = new Padding(2, 2, 2, 2);
            lboxAvsnitt.Name = "lboxAvsnitt";
            lboxAvsnitt.Size = new Size(700, 964);
            lboxAvsnitt.TabIndex = 1;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(1062, 1148);
            rtbBeskrivning.Margin = new Padding(2, 2, 2, 2);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(700, 356);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(71, 708);
            tbNamn.Margin = new Padding(2, 2, 2, 2);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(331, 39);
            tbNamn.TabIndex = 3;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(71, 772);
            btnLaggTill.Margin = new Padding(2, 2, 2, 2);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(163, 47);
            btnLaggTill.TabIndex = 4;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // dgvPrenumerationer
            // 
            dgvPrenumerationer.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPrenumerationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrenumerationer.GridColor = SystemColors.GradientInactiveCaption;
            dgvPrenumerationer.Location = new Point(71, 107);
            dgvPrenumerationer.Margin = new Padding(2, 2, 2, 2);
            dgvPrenumerationer.Name = "dgvPrenumerationer";
            dgvPrenumerationer.RowHeadersWidth = 123;
            dgvPrenumerationer.Size = new Size(903, 301);
            dgvPrenumerationer.TabIndex = 5;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(71, 672);
            lblURL.Margin = new Padding(2, 0, 2, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(55, 32);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(1062, 1114);
            lblBeskrivning.Margin = new Padding(2, 0, 2, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(137, 32);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(71, 73);
            Prenumerationer.Margin = new Padding(2, 0, 2, 0);
            Prenumerationer.Name = "Prenumerationer";
            Prenumerationer.Size = new Size(193, 32);
            Prenumerationer.TabIndex = 9;
            Prenumerationer.Text = "Prenumerationer";
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPodcasts.Location = new Point(59, 0);
            lblPodcasts.Margin = new Padding(2, 0, 2, 0);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(211, 65);
            lblPodcasts.TabIndex = 10;
            lblPodcasts.Text = "Podcasts";
            // 
            // lblLaggTillPodcast
            // 
            lblLaggTillPodcast.AutoSize = true;
            lblLaggTillPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaggTillPodcast.Location = new Point(71, 431);
            lblLaggTillPodcast.Margin = new Padding(2, 0, 2, 0);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(255, 45);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(71, 529);
            tbTitel.Margin = new Padding(2, 2, 2, 2);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(331, 39);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(71, 582);
            lblKategori.Margin = new Padding(2, 0, 2, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(103, 32);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(71, 617);
            cboxKategori.Margin = new Padding(2, 2, 2, 2);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(331, 40);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(71, 495);
            lblTitel.Margin = new Padding(2, 0, 2, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(79, 32);
            lblTitel.TabIndex = 16;
            lblTitel.Text = "Namn";
            // 
            // lblRedigeraPodcast
            // 
            lblRedigeraPodcast.AutoSize = true;
            lblRedigeraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraPodcast.Location = new Point(487, 431);
            lblRedigeraPodcast.Margin = new Padding(2, 0, 2, 0);
            lblRedigeraPodcast.Name = "lblRedigeraPodcast";
            lblRedigeraPodcast.Size = new Size(267, 45);
            lblRedigeraPodcast.TabIndex = 18;
            lblRedigeraPodcast.Text = "Redigera podcast";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(1062, 68);
            lblAvsnitt.Margin = new Padding(2, 0, 2, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(87, 32);
            lblAvsnitt.TabIndex = 19;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblSorteraPodcast
            // 
            lblSorteraPodcast.AutoSize = true;
            lblSorteraPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSorteraPodcast.Location = new Point(71, 890);
            lblSorteraPodcast.Margin = new Padding(2, 0, 2, 0);
            lblSorteraPodcast.Name = "lblSorteraPodcast";
            lblSorteraPodcast.Size = new Size(244, 45);
            lblSorteraPodcast.TabIndex = 20;
            lblSorteraPodcast.Text = "Sortera podcast";
            // 
            // cboxSorteraPodcast
            // 
            cboxSorteraPodcast.FormattingEnabled = true;
            cboxSorteraPodcast.Location = new Point(71, 990);
            cboxSorteraPodcast.Margin = new Padding(2, 2, 2, 2);
            cboxSorteraPodcast.Name = "cboxSorteraPodcast";
            cboxSorteraPodcast.Size = new Size(331, 40);
            cboxSorteraPodcast.TabIndex = 21;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(71, 958);
            lblValjKategori.Margin = new Padding(2, 0, 2, 0);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(145, 32);
            lblValjKategori.TabIndex = 22;
            lblValjKategori.Text = "Välj kategori";
            // 
            // btnVisaPodcast
            // 
            btnVisaPodcast.Location = new Point(71, 1062);
            btnVisaPodcast.Margin = new Padding(2, 2, 2, 2);
            btnVisaPodcast.Name = "btnVisaPodcast";
            btnVisaPodcast.Size = new Size(163, 47);
            btnVisaPodcast.TabIndex = 23;
            btnVisaPodcast.Text = "Visa podcast";
            btnVisaPodcast.UseVisualStyleBackColor = true;
            // 
            // lboxPodcastInomKategori
            // 
            lboxPodcastInomKategori.FormattingEnabled = true;
            lboxPodcastInomKategori.Location = new Point(71, 1148);
            lboxPodcastInomKategori.Margin = new Padding(2, 2, 2, 2);
            lboxPodcastInomKategori.Name = "lboxPodcastInomKategori";
            lboxPodcastInomKategori.Size = new Size(899, 356);
            lboxPodcastInomKategori.TabIndex = 24;
            // 
            // lblRedigeraKategori
            // 
            lblRedigeraKategori.AutoSize = true;
            lblRedigeraKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraKategori.Location = new Point(487, 890);
            lblRedigeraKategori.Margin = new Padding(2, 0, 2, 0);
            lblRedigeraKategori.Name = "lblRedigeraKategori";
            lblRedigeraKategori.Size = new Size(271, 45);
            lblRedigeraKategori.TabIndex = 25;
            lblRedigeraKategori.Text = "Redigera kategori";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1857, 1463);
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
            Margin = new Padding(2, 2, 2, 2);
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
