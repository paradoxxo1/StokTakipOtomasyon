namespace StokSatis
{
	partial class frmÜrünListele
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
			dataGridView1 = new DataGridView();
			lblMiktarı = new Label();
			btnGüncelle = new Button();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			SatışFiyatıTxt = new TextBox();
			AlışFiyatıTxt = new TextBox();
			MiktarıTxt = new TextBox();
			ÜrünAdıTxt = new TextBox();
			MarkaTxt = new TextBox();
			KategoriTxt = new TextBox();
			BarkodNoTxt = new TextBox();
			btnSil = new Button();
			txtBarkodNoAra = new TextBox();
			label1 = new Label();
			comboKategori = new ComboBox();
			comboMarka = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			btnMarkaGuncelle = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.Window;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(413, 107);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(675, 480);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			// 
			// lblMiktarı
			// 
			lblMiktarı.AutoSize = true;
			lblMiktarı.Location = new Point(416, 594);
			lblMiktarı.Name = "lblMiktarı";
			lblMiktarı.Size = new Size(0, 20);
			lblMiktarı.TabIndex = 36;
			// 
			// btnGüncelle
			// 
			btnGüncelle.Location = new Point(175, 522);
			btnGüncelle.Name = "btnGüncelle";
			btnGüncelle.Size = new Size(134, 65);
			btnGüncelle.TabIndex = 29;
			btnGüncelle.Text = "Güncelle";
			btnGüncelle.UseVisualStyleBackColor = true;
			btnGüncelle.Click += btnGüncelle_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(20, 475);
			label8.Name = "label8";
			label8.Size = new Size(79, 20);
			label8.TabIndex = 35;
			label8.Text = "Satış Fiyatı";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(20, 419);
			label9.Name = "label9";
			label9.Size = new Size(72, 20);
			label9.TabIndex = 34;
			label9.Text = "Alış Fiyatı";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(20, 367);
			label10.Name = "label10";
			label10.Size = new Size(55, 20);
			label10.TabIndex = 33;
			label10.Text = "Miktarı";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(20, 311);
			label11.Name = "label11";
			label11.Size = new Size(67, 20);
			label11.TabIndex = 32;
			label11.Text = "Ürün Adı";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(20, 255);
			label12.Name = "label12";
			label12.Size = new Size(50, 20);
			label12.TabIndex = 31;
			label12.Text = "Marka";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(15, 199);
			label13.Name = "label13";
			label13.Size = new Size(66, 20);
			label13.TabIndex = 30;
			label13.Text = "Kategori";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(15, 143);
			label14.Name = "label14";
			label14.Size = new Size(80, 20);
			label14.TabIndex = 28;
			label14.Text = "Barkod No";
			// 
			// SatışFiyatıTxt
			// 
			SatışFiyatıTxt.Location = new Point(135, 472);
			SatışFiyatıTxt.Name = "SatışFiyatıTxt";
			SatışFiyatıTxt.Size = new Size(235, 27);
			SatışFiyatıTxt.TabIndex = 27;
			// 
			// AlışFiyatıTxt
			// 
			AlışFiyatıTxt.Location = new Point(135, 416);
			AlışFiyatıTxt.Name = "AlışFiyatıTxt";
			AlışFiyatıTxt.Size = new Size(235, 27);
			AlışFiyatıTxt.TabIndex = 26;
			// 
			// MiktarıTxt
			// 
			MiktarıTxt.Location = new Point(135, 360);
			MiktarıTxt.Name = "MiktarıTxt";
			MiktarıTxt.Size = new Size(235, 27);
			MiktarıTxt.TabIndex = 25;
			// 
			// ÜrünAdıTxt
			// 
			ÜrünAdıTxt.Location = new Point(135, 304);
			ÜrünAdıTxt.Name = "ÜrünAdıTxt";
			ÜrünAdıTxt.Size = new Size(235, 27);
			ÜrünAdıTxt.TabIndex = 24;
			// 
			// MarkaTxt
			// 
			MarkaTxt.Location = new Point(135, 248);
			MarkaTxt.Name = "MarkaTxt";
			MarkaTxt.ReadOnly = true;
			MarkaTxt.Size = new Size(235, 27);
			MarkaTxt.TabIndex = 23;
			// 
			// KategoriTxt
			// 
			KategoriTxt.Location = new Point(135, 192);
			KategoriTxt.Name = "KategoriTxt";
			KategoriTxt.ReadOnly = true;
			KategoriTxt.Size = new Size(235, 27);
			KategoriTxt.TabIndex = 22;
			// 
			// BarkodNoTxt
			// 
			BarkodNoTxt.Location = new Point(135, 136);
			BarkodNoTxt.Name = "BarkodNoTxt";
			BarkodNoTxt.Size = new Size(235, 27);
			BarkodNoTxt.TabIndex = 21;
			// 
			// btnSil
			// 
			btnSil.BackColor = Color.IndianRed;
			btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnSil.ForeColor = SystemColors.InactiveCaptionText;
			btnSil.Location = new Point(977, 40);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(111, 58);
			btnSil.TabIndex = 37;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = false;
			btnSil.Click += btnSil_Click_1;
			// 
			// txtBarkodNoAra
			// 
			txtBarkodNoAra.Location = new Point(599, 59);
			txtBarkodNoAra.Name = "txtBarkodNoAra";
			txtBarkodNoAra.Size = new Size(235, 27);
			txtBarkodNoAra.TabIndex = 38;
			txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(413, 59);
			label1.Name = "label1";
			label1.Size = new Size(161, 20);
			label1.TabIndex = 39;
			label1.Text = "Barkod No'ya Göre Ara";
			// 
			// comboKategori
			// 
			comboKategori.FormattingEnabled = true;
			comboKategori.Location = new Point(529, 616);
			comboKategori.Name = "comboKategori";
			comboKategori.Size = new Size(235, 28);
			comboKategori.TabIndex = 40;
			comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
			// 
			// comboMarka
			// 
			comboMarka.FormattingEnabled = true;
			comboMarka.Location = new Point(529, 678);
			comboMarka.Name = "comboMarka";
			comboMarka.Size = new Size(235, 28);
			comboMarka.TabIndex = 41;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(414, 681);
			label2.Name = "label2";
			label2.Size = new Size(50, 20);
			label2.TabIndex = 43;
			label2.Text = "Marka";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(409, 625);
			label3.Name = "label3";
			label3.Size = new Size(66, 20);
			label3.TabIndex = 42;
			label3.Text = "Kategori";
			// 
			// btnMarkaGuncelle
			// 
			btnMarkaGuncelle.Location = new Point(789, 633);
			btnMarkaGuncelle.Name = "btnMarkaGuncelle";
			btnMarkaGuncelle.Size = new Size(134, 65);
			btnMarkaGuncelle.TabIndex = 44;
			btnMarkaGuncelle.Text = "Marka Güncelle";
			btnMarkaGuncelle.UseVisualStyleBackColor = true;
			btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
			// 
			// frmÜrünListele
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(1134, 729);
			Controls.Add(btnMarkaGuncelle);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(comboMarka);
			Controls.Add(comboKategori);
			Controls.Add(label1);
			Controls.Add(txtBarkodNoAra);
			Controls.Add(btnSil);
			Controls.Add(lblMiktarı);
			Controls.Add(btnGüncelle);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(label10);
			Controls.Add(label11);
			Controls.Add(label12);
			Controls.Add(label13);
			Controls.Add(label14);
			Controls.Add(SatışFiyatıTxt);
			Controls.Add(AlışFiyatıTxt);
			Controls.Add(MiktarıTxt);
			Controls.Add(ÜrünAdıTxt);
			Controls.Add(MarkaTxt);
			Controls.Add(KategoriTxt);
			Controls.Add(BarkodNoTxt);
			Controls.Add(dataGridView1);
			Name = "frmÜrünListele";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ürün Listeleme Sayfası";
			Load += frmÜrünListele_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label lblMiktarı;
		private Button btnGüncelle;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private TextBox SatışFiyatıTxt;
		private TextBox AlışFiyatıTxt;
		private TextBox MiktarıTxt;
		private TextBox ÜrünAdıTxt;
		private TextBox MarkaTxt;
		private TextBox KategoriTxt;
		private TextBox BarkodNoTxt;
		private Button btnSil;
		private TextBox txtBarkodNoAra;
		private Label label1;
		private ComboBox comboKategori;
		private ComboBox comboMarka;
		private Label label2;
		private Label label3;
		private Button btnMarkaGuncelle;
	}
}