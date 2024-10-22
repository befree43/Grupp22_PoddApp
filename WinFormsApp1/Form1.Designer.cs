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
            lbAvsnitt = new ListBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvPrenumerationer).BeginInit();
            SuspendLayout();
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.Location = new Point(791, 53);
            lbAvsnitt.Margin = new Padding(1, 1, 1, 1);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(267, 184);
            lbAvsnitt.TabIndex = 1;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(791, 281);
            rtbBeskrivning.Margin = new Padding(1, 1, 1, 1);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(267, 241);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(43, 442);
            tbNamn.Margin = new Padding(1, 1, 1, 1);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(205, 27);
            tbNamn.TabIndex = 3;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(43, 483);
            btnLaggTill.Margin = new Padding(1, 1, 1, 1);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(90, 29);
            btnLaggTill.TabIndex = 4;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // dgvPrenumerationer
            // 
            dgvPrenumerationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrenumerationer.Location = new Point(43, 67);
            dgvPrenumerationer.Margin = new Padding(1, 1, 1, 1);
            dgvPrenumerationer.Name = "dgvPrenumerationer";
            dgvPrenumerationer.RowHeadersWidth = 123;
            dgvPrenumerationer.Size = new Size(446, 188);
            dgvPrenumerationer.TabIndex = 5;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(43, 420);
            lblURL.Margin = new Padding(1, 0, 1, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(35, 20);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(791, 260);
            lblBeskrivning.Margin = new Padding(1, 0, 1, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(84, 20);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(43, 45);
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
            lblLaggTillPodcast.Location = new Point(43, 269);
            lblLaggTillPodcast.Margin = new Padding(1, 0, 1, 0);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(157, 28);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(43, 330);
            tbTitel.Margin = new Padding(1, 1, 1, 1);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(205, 27);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(43, 364);
            lblKategori.Margin = new Padding(1, 0, 1, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(43, 385);
            cboxKategori.Margin = new Padding(1, 1, 1, 1);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(205, 28);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(43, 309);
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
            lblAvsnitt.Location = new Point(789, 23);
            lblAvsnitt.Margin = new Padding(1, 0, 1, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(54, 20);
            lblAvsnitt.TabIndex = 19;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 517);
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
            Controls.Add(lbAvsnitt);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPrenumerationer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbAvsnitt;
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
    }
}
