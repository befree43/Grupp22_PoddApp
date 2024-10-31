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
            lblAvsnitt = new Label();
            cboxSorteraPodcast = new ComboBox();
            lblValjKategori = new Label();
            lblRedigeraKategori = new Label();
            lvPrenumerationer = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tbNyKategori = new TextBox();
            btnLäggTillKategori = new Button();
            btnÄndraKategori = new Button();
            btnTaBortKategori = new Button();
            lboxKategori = new ListBox();
            btnSparaPod = new Button();
            lblPodTitle = new Label();
            tbPodNamn = new TextBox();
            cbPodKategori = new ComboBox();
            btnRaderaPod = new Button();
            lblNamnPodcast = new Label();
            lblKategoriPodcast = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lboxAvsnitt
            // 
            lboxAvsnitt.FormattingEnabled = true;
            lboxAvsnitt.Location = new Point(1126, 201);
            lboxAvsnitt.Margin = new Padding(2);
            lboxAvsnitt.Name = "lboxAvsnitt";
            lboxAvsnitt.Size = new Size(699, 676);
            lboxAvsnitt.TabIndex = 1;
            lboxAvsnitt.SelectedIndexChanged += lboxAvsnitt_SelectedIndexChanged;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(1126, 946);
            rtbBeskrivning.Margin = new Padding(2);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(699, 356);
            rtbBeskrivning.TabIndex = 2;
            rtbBeskrivning.Text = "";
            // 
            // tbURL
            // 
            tbURL.Location = new Point(80, 806);
            tbURL.Margin = new Padding(2);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(331, 39);
            tbURL.TabIndex = 3;
            // 
            // btnLaggTillPodcast
            // 
            btnLaggTillPodcast.Location = new Point(80, 870);
            btnLaggTillPodcast.Margin = new Padding(2);
            btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            btnLaggTillPodcast.Size = new Size(163, 47);
            btnLaggTillPodcast.TabIndex = 4;
            btnLaggTillPodcast.Text = "Lägg till";
            btnLaggTillPodcast.UseVisualStyleBackColor = true;
            btnLaggTillPodcast.Click += btnLaggTillPodcast_Click;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(80, 770);
            lblURL.Margin = new Padding(2, 0, 2, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(55, 32);
            lblURL.TabIndex = 7;
            lblURL.Text = "URL";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(1126, 911);
            lblBeskrivning.Margin = new Padding(2, 0, 2, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(137, 32);
            lblBeskrivning.TabIndex = 8;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // Prenumerationer
            // 
            Prenumerationer.AutoSize = true;
            Prenumerationer.Location = new Point(80, 167);
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
            lblPodcasts.Location = new Point(72, 68);
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
            lblLaggTillPodcast.Location = new Point(80, 529);
            lblLaggTillPodcast.Margin = new Padding(2, 0, 2, 0);
            lblLaggTillPodcast.Name = "lblLaggTillPodcast";
            lblLaggTillPodcast.Size = new Size(255, 45);
            lblLaggTillPodcast.TabIndex = 11;
            lblLaggTillPodcast.Text = "Lägg till podcast";
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(80, 627);
            tbTitel.Margin = new Padding(2);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(331, 39);
            tbTitel.TabIndex = 12;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(471, 682);
            lblKategori.Margin = new Padding(2, 0, 2, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(171, 32);
            lblKategori.TabIndex = 14;
            lblKategori.Text = "Ändra kategori";
            // 
            // cboxKategori
            // 
            cboxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxKategori.FormattingEnabled = true;
            cboxKategori.Location = new Point(80, 717);
            cboxKategori.Margin = new Padding(2);
            cboxKategori.Name = "cboxKategori";
            cboxKategori.Size = new Size(331, 40);
            cboxKategori.TabIndex = 15;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(471, 589);
            lblTitel.Margin = new Padding(2, 0, 2, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(145, 32);
            lblTitel.TabIndex = 16;
            lblTitel.Text = "Ändra namn";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(1126, 169);
            lblAvsnitt.Margin = new Padding(2, 0, 2, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(87, 32);
            lblAvsnitt.TabIndex = 19;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // cboxSorteraPodcast
            // 
            cboxSorteraPodcast.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxSorteraPodcast.FormattingEnabled = true;
            cboxSorteraPodcast.Location = new Point(736, 152);
            cboxSorteraPodcast.Margin = new Padding(2);
            cboxSorteraPodcast.Name = "cboxSorteraPodcast";
            cboxSorteraPodcast.Size = new Size(331, 40);
            cboxSorteraPodcast.TabIndex = 21;
            cboxSorteraPodcast.SelectedIndexChanged += cboxSorteraPodcast_SelectedIndexChanged;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Location = new Point(736, 118);
            lblValjKategori.Margin = new Padding(2, 0, 2, 0);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(145, 32);
            lblValjKategori.TabIndex = 22;
            lblValjKategori.Text = "Välj kategori";
            // 
            // lblRedigeraKategori
            // 
            lblRedigeraKategori.AutoSize = true;
            lblRedigeraKategori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedigeraKategori.Location = new Point(80, 960);
            lblRedigeraKategori.Margin = new Padding(2, 0, 2, 0);
            lblRedigeraKategori.Name = "lblRedigeraKategori";
            lblRedigeraKategori.Size = new Size(271, 45);
            lblRedigeraKategori.TabIndex = 25;
            lblRedigeraKategori.Text = "Redigera kategori";
            // 
            // lvPrenumerationer
            // 
            lvPrenumerationer.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvPrenumerationer.FullRowSelect = true;
            lvPrenumerationer.Location = new Point(80, 201);
            lvPrenumerationer.Margin = new Padding(6, 7, 6, 7);
            lvPrenumerationer.MultiSelect = false;
            lvPrenumerationer.Name = "lvPrenumerationer";
            lvPrenumerationer.Size = new Size(987, 290);
            lvPrenumerationer.TabIndex = 26;
            lvPrenumerationer.UseCompatibleStateImageBehavior = false;
            lvPrenumerationer.View = View.Details;
            lvPrenumerationer.SelectedIndexChanged += lvPrenumerationer_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Titel";
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Url";
            columnHeader4.Width = 350;
            // 
            // tbNyKategori
            // 
            tbNyKategori.Location = new Point(72, 1029);
            tbNyKategori.Name = "tbNyKategori";
            tbNyKategori.Size = new Size(466, 39);
            tbNyKategori.TabIndex = 27;
            tbNyKategori.TextChanged += tbNyKategori_TextChanged;
            // 
            // btnLäggTillKategori
            // 
            btnLäggTillKategori.Location = new Point(72, 1089);
            btnLäggTillKategori.Name = "btnLäggTillKategori";
            btnLäggTillKategori.Size = new Size(150, 46);
            btnLäggTillKategori.TabIndex = 28;
            btnLäggTillKategori.Text = "Lägg till";
            btnLäggTillKategori.UseVisualStyleBackColor = true;
            btnLäggTillKategori.Click += btnLäggTillKategori_Click;
            // 
            // btnÄndraKategori
            // 
            btnÄndraKategori.Location = new Point(228, 1089);
            btnÄndraKategori.Name = "btnÄndraKategori";
            btnÄndraKategori.Size = new Size(150, 46);
            btnÄndraKategori.TabIndex = 29;
            btnÄndraKategori.Text = "Ändra";
            btnÄndraKategori.UseVisualStyleBackColor = true;
            btnÄndraKategori.Click += btnÄndraKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(388, 1089);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(150, 46);
            btnTaBortKategori.TabIndex = 30;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // lboxKategori
            // 
            lboxKategori.FormattingEnabled = true;
            lboxKategori.Location = new Point(80, 1162);
            lboxKategori.Name = "lboxKategori";
            lboxKategori.Size = new Size(452, 164);
            lboxKategori.TabIndex = 31;
            lboxKategori.SelectedIndexChanged += lboxKategori_SelectedIndexChanged;
            // 
            // btnSparaPod
            // 
            btnSparaPod.Location = new Point(468, 778);
            btnSparaPod.Name = "btnSparaPod";
            btnSparaPod.Size = new Size(150, 46);
            btnSparaPod.TabIndex = 32;
            btnSparaPod.Text = "Spara";
            btnSparaPod.UseVisualStyleBackColor = true;
            btnSparaPod.Click += btnSparaPod_Click;
            // 
            // lblPodTitle
            // 
            lblPodTitle.AutoSize = true;
            lblPodTitle.Font = new Font("Segoe UI", 12F);
            lblPodTitle.Location = new Point(471, 542);
            lblPodTitle.Name = "lblPodTitle";
            lblPodTitle.Size = new Size(131, 45);
            lblPodTitle.TabIndex = 33;
            lblPodTitle.Text = "Podcast";
            // 
            // tbPodNamn
            // 
            tbPodNamn.Location = new Point(468, 636);
            tbPodNamn.Name = "tbPodNamn";
            tbPodNamn.Size = new Size(200, 39);
            tbPodNamn.TabIndex = 34;
            // 
            // cbPodKategori
            // 
            cbPodKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPodKategori.FormattingEnabled = true;
            cbPodKategori.Location = new Point(468, 717);
            cbPodKategori.Name = "cbPodKategori";
            cbPodKategori.Size = new Size(242, 40);
            cbPodKategori.TabIndex = 35;
            // 
            // btnRaderaPod
            // 
            btnRaderaPod.Location = new Point(802, 627);
            btnRaderaPod.Name = "btnRaderaPod";
            btnRaderaPod.Size = new Size(150, 46);
            btnRaderaPod.TabIndex = 36;
            btnRaderaPod.Text = "Ta bort";
            btnRaderaPod.UseVisualStyleBackColor = true;
            btnRaderaPod.Click += btnRaderaPod_Click;
            // 
            // lblNamnPodcast
            // 
            lblNamnPodcast.AutoSize = true;
            lblNamnPodcast.Location = new Point(86, 587);
            lblNamnPodcast.Name = "lblNamnPodcast";
            lblNamnPodcast.Size = new Size(79, 32);
            lblNamnPodcast.TabIndex = 37;
            lblNamnPodcast.Text = "Namn";
            // 
            // lblKategoriPodcast
            // 
            lblKategoriPodcast.AutoSize = true;
            lblKategoriPodcast.Location = new Point(83, 678);
            lblKategoriPodcast.Name = "lblKategoriPodcast";
            lblKategoriPodcast.Size = new Size(103, 32);
            lblKategoriPodcast.TabIndex = 38;
            lblKategoriPodcast.Text = "Kategori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(802, 542);
            label1.Name = "label1";
            label1.Size = new Size(240, 45);
            label1.TabIndex = 39;
            label1.Text = "Ta bort podcast";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1963, 1462);
            Controls.Add(label1);
            Controls.Add(lblKategoriPodcast);
            Controls.Add(lblNamnPodcast);
            Controls.Add(btnRaderaPod);
            Controls.Add(cbPodKategori);
            Controls.Add(tbPodNamn);
            Controls.Add(lblPodTitle);
            Controls.Add(btnSparaPod);
            Controls.Add(lboxKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnÄndraKategori);
            Controls.Add(btnLäggTillKategori);
            Controls.Add(tbNyKategori);
            Controls.Add(lvPrenumerationer);
            Controls.Add(lblRedigeraKategori);
            Controls.Add(lblValjKategori);
            Controls.Add(cboxSorteraPodcast);
            Controls.Add(lblAvsnitt);
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
            Margin = new Padding(2);
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
        private ComboBox cboxSorteraPodcast;
        private Label lblValjKategori;
        private Label lblRedigeraKategori;
        private Button btnLaggTillPodcast;
        private ListView lvPrenumerationer;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbNyKategori;
        private Button btnLäggTillKategori;
        private Button btnÄndraKategori;
        private Button btnTaBortKategori;
        private ListBox lboxKategori;
        private ColumnHeader columnHeader4;
        private Button btnSparaPod;
        private Label lblPodTitle;
        private TextBox tbPodNamn;
        private ComboBox cbPodKategori;
        private Button btnRaderaPod;
        private Label lblNamnPodcast;
        private Label lblKategoriPodcast;
        private Label label1;
    }
}
