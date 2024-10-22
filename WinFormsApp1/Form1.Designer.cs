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
            lblAvsnitt = new Label();
            lblURL = new Label();
            lblBeskrivning = new Label();
            Prenumerationer = new Label();
            lblPodcasts = new Label();
            lblLaggTillPodcast = new Label();
            tbTitel = new TextBox();
            lblKategori = new Label();
            cboxKategori = new ComboBox();
            lblTitel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrenumerationer).BeginInit();
            SuspendLayout();
            // 
            // lbAvsnitt
            // 
            lbAvsnitt.FormattingEnabled = true;
            lbAvsnitt.Location = new Point(1210, 109);
            lbAvsnitt.Name = "lbAvsnitt";
            lbAvsnitt.Size = new Size(662, 436);
            lbAvsnitt.TabIndex = 1;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(1210, 656);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(662, 572);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(107, 1060);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(507, 55);
            tbNamn.TabIndex = 3;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(107, 1159);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(225, 69);
            btnLaggTill.TabIndex = 4;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            // 
            // dgvPrenumerationer
            // 
            dgvPrenumerationer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrenumerationer.Location = new Point(107, 160);
            dgvPrenumerationer.Name = "dgvPrenumerationer";
            dgvPrenumerationer.RowHeadersWidth = 123;
            dgvPrenumerationer.Size = new Size(953, 450);
            dgvPrenumerationer.TabIndex = 5;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(1210, 47);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(127, 48);
            lblAvsnitt.TabIndex = 6;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(107, 1009);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(84, 48);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(1210, 585);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(202, 48);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(107, 109);
            Prenumerationer.Name = "Prenumerationer";
            Prenumerationer.Size = new Size(287, 48);
            Prenumerationer.TabIndex = 9;
            Prenumerationer.Text = "Prenumerationer";
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPodcasts.Location = new Point(91, -1);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(317, 96);
            lblPodcasts.TabIndex = 10;
            lblPodcasts.Text = "Podcasts";
            // 
            // lblLaggTillPodcast
            // 
            lblLaggTillPodcast.AutoSize = true;
            lblLaggTillPodcast.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLaggTillPodcast.Location = new Point(107, 646);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(375, 65);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(107, 792);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(507, 55);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(107, 874);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(154, 48);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(107, 925);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(507, 56);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(107, 741);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(116, 48);
            lblTitel.TabIndex = 16;
            lblTitel.Text = "Namn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2947, 1309);
            Controls.Add(lblTitel);
            Controls.Add(cboxKategori);
            Controls.Add(lblKategori);
            Controls.Add(tbTitel);
            Controls.Add(lblLaggTillPodcast);
            Controls.Add(lblPodcasts);
            Controls.Add(Prenumerationer);
            Controls.Add(lblBeskrivning);
            Controls.Add(lblURL);
            Controls.Add(lblAvsnitt);
            Controls.Add(dgvPrenumerationer);
            Controls.Add(btnLaggTill);
            Controls.Add(tbNamn);
            Controls.Add(rtbBeskrivning);
            Controls.Add(lbAvsnitt);
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
        private Label lblAvsnitt;
        private Label lblURL;
        private Label lblBeskrivning;
        private Label Prenumerationer;
        private Label lblPodcasts;
        private Label lblLaggTillPodcast;
        private TextBox tbTitel;
        private Label lblKategori;
        private ComboBox cboxKategori;
        private Label lblTitel;
    }
}
