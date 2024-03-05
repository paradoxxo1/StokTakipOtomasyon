namespace StokSatis
{
	partial class frmSatis
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
			dataGridView1 = new DataGridView();
			groupBox1 = new GroupBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtTelefon = new TextBox();
			txtAdSoyad = new TextBox();
			txtTc = new TextBox();
			groupBox2 = new GroupBox();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			txtToplamFiyat = new TextBox();
			txtSatışFiyatı = new TextBox();
			txtMiktar = new TextBox();
			txtÜrünAdı = new TextBox();
			txtBarkodNo = new TextBox();
			btnEkle = new Button();
			btnSil = new Button();
			btnSatışİptal = new Button();
			btnSatışYap = new Button();
			label9 = new Label();
			lblGenelToplam = new Label();
			panel1 = new Panel();
			button2 = new Button();
			button1 = new Button();
			button9 = new Button();
			button8 = new Button();
			button7 = new Button();
			button6 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.ButtonFace;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(276, 152);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(641, 387);
			dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtTelefon);
			groupBox1.Controls.Add(txtAdSoyad);
			groupBox1.Controls.Add(txtTc);
			groupBox1.Location = new Point(12, 178);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(250, 148);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Müşteri İşlemleri";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 111);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 5;
			label3.Text = "Telefon";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 67);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 4;
			label2.Text = "Ad Soyad";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 23);
			label1.Name = "label1";
			label1.Size = new Size(25, 20);
			label1.TabIndex = 3;
			label1.Text = "TC";
			// 
			// txtTelefon
			// 
			txtTelefon.Location = new Point(107, 104);
			txtTelefon.Name = "txtTelefon";
			txtTelefon.Size = new Size(125, 27);
			txtTelefon.TabIndex = 2;
			// 
			// txtAdSoyad
			// 
			txtAdSoyad.Location = new Point(107, 64);
			txtAdSoyad.Name = "txtAdSoyad";
			txtAdSoyad.Size = new Size(125, 27);
			txtAdSoyad.TabIndex = 1;
			// 
			// txtTc
			// 
			txtTc.Location = new Point(107, 26);
			txtTc.Name = "txtTc";
			txtTc.Size = new Size(125, 27);
			txtTc.TabIndex = 0;
			txtTc.TextChanged += txtTc_TextChanged;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(txtToplamFiyat);
			groupBox2.Controls.Add(txtSatışFiyatı);
			groupBox2.Controls.Add(txtMiktar);
			groupBox2.Controls.Add(txtÜrünAdı);
			groupBox2.Controls.Add(txtBarkodNo);
			groupBox2.Location = new Point(12, 356);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(250, 211);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Ürün İşlemleri";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 163);
			label8.Name = "label8";
			label8.Size = new Size(98, 20);
			label8.TabIndex = 11;
			label8.Text = "Toplam Fiyatı";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 132);
			label7.Name = "label7";
			label7.Size = new Size(79, 20);
			label7.TabIndex = 10;
			label7.Text = "Satış Fiyatı";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 99);
			label6.Name = "label6";
			label6.Size = new Size(55, 20);
			label6.TabIndex = 9;
			label6.Text = "Miktarı";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 66);
			label5.Name = "label5";
			label5.Size = new Size(67, 20);
			label5.TabIndex = 8;
			label5.Text = "Ürün Adı";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 33);
			label4.Name = "label4";
			label4.Size = new Size(80, 20);
			label4.TabIndex = 6;
			label4.Text = "Barkod No";
			// 
			// txtToplamFiyat
			// 
			txtToplamFiyat.Location = new Point(107, 156);
			txtToplamFiyat.Name = "txtToplamFiyat";
			txtToplamFiyat.Size = new Size(125, 27);
			txtToplamFiyat.TabIndex = 7;
			// 
			// txtSatışFiyatı
			// 
			txtSatışFiyatı.Location = new Point(107, 125);
			txtSatışFiyatı.Name = "txtSatışFiyatı";
			txtSatışFiyatı.Size = new Size(125, 27);
			txtSatışFiyatı.TabIndex = 6;
			// 
			// txtMiktar
			// 
			txtMiktar.Location = new Point(107, 92);
			txtMiktar.Name = "txtMiktar";
			txtMiktar.Size = new Size(125, 27);
			txtMiktar.TabIndex = 5;
			txtMiktar.Text = "1";
			txtMiktar.TextAlign = HorizontalAlignment.Center;
			txtMiktar.TextChanged += txtMiktar_TextChanged;
			// 
			// txtÜrünAdı
			// 
			txtÜrünAdı.Location = new Point(107, 59);
			txtÜrünAdı.Name = "txtÜrünAdı";
			txtÜrünAdı.Size = new Size(125, 27);
			txtÜrünAdı.TabIndex = 4;
			// 
			// txtBarkodNo
			// 
			txtBarkodNo.Location = new Point(107, 26);
			txtBarkodNo.Name = "txtBarkodNo";
			txtBarkodNo.Size = new Size(125, 27);
			txtBarkodNo.TabIndex = 3;
			txtBarkodNo.TextChanged += txtBarkod_TextChanged;
			// 
			// btnEkle
			// 
			btnEkle.Location = new Point(276, 557);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(131, 61);
			btnEkle.TabIndex = 3;
			btnEkle.Text = "Ekle";
			btnEkle.UseVisualStyleBackColor = true;
			btnEkle.Click += btnEkle_Click;
			// 
			// btnSil
			// 
			btnSil.Location = new Point(937, 155);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(114, 54);
			btnSil.TabIndex = 4;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = true;
			btnSil.Click += btnSil_Click;
			// 
			// btnSatışİptal
			// 
			btnSatışİptal.Location = new Point(937, 233);
			btnSatışİptal.Name = "btnSatışİptal";
			btnSatışİptal.Size = new Size(114, 64);
			btnSatışİptal.TabIndex = 5;
			btnSatışİptal.Text = "Satış İptal";
			btnSatışİptal.UseVisualStyleBackColor = true;
			btnSatışİptal.Click += btnSatışİptal_Click;
			// 
			// btnSatışYap
			// 
			btnSatışYap.Location = new Point(794, 557);
			btnSatışYap.Name = "btnSatışYap";
			btnSatışYap.Size = new Size(123, 61);
			btnSatışYap.TabIndex = 6;
			btnSatışYap.Text = "Satış Yap";
			btnSatışYap.UseVisualStyleBackColor = true;
			btnSatışYap.Click += btnSatışYap_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(580, 559);
			label9.Name = "label9";
			label9.Size = new Size(112, 20);
			label9.TabIndex = 7;
			label9.Text = "Genel Toplam : ";
			// 
			// lblGenelToplam
			// 
			lblGenelToplam.AutoSize = true;
			lblGenelToplam.Location = new Point(705, 561);
			lblGenelToplam.Name = "lblGenelToplam";
			lblGenelToplam.Size = new Size(0, 20);
			lblGenelToplam.TabIndex = 8;
			// 
			// panel1
			// 
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button9);
			panel1.Controls.Add(button8);
			panel1.Controls.Add(button7);
			panel1.Controls.Add(button6);
			panel1.Controls.Add(button5);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1063, 125);
			panel1.TabIndex = 9;
			// 
			// button2
			// 
			button2.Location = new Point(711, 35);
			button2.Name = "button2";
			button2.Size = new Size(134, 63);
			button2.TabIndex = 6;
			button2.Text = "Kategori";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(571, 35);
			button1.Name = "button1";
			button1.Size = new Size(134, 63);
			button1.TabIndex = 5;
			button1.Text = "Marka";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button9
			// 
			button9.Location = new Point(922, 35);
			button9.Name = "button9";
			button9.Size = new Size(129, 63);
			button9.TabIndex = 4;
			button9.Text = "Satışları Listeleme";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// button8
			// 
			button8.Location = new Point(431, 35);
			button8.Name = "button8";
			button8.Size = new Size(134, 63);
			button8.TabIndex = 3;
			button8.Text = "Ürün Listeleme";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button7
			// 
			button7.Location = new Point(291, 35);
			button7.Name = "button7";
			button7.Size = new Size(134, 63);
			button7.TabIndex = 2;
			button7.Text = "Ürün Ekleme";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button6
			// 
			button6.Location = new Point(151, 35);
			button6.Name = "button6";
			button6.Size = new Size(134, 63);
			button6.TabIndex = 1;
			button6.Text = "Müşteri Listeleme";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button5
			// 
			button5.Location = new Point(3, 35);
			button5.Name = "button5";
			button5.Size = new Size(142, 63);
			button5.TabIndex = 0;
			button5.Text = "Müşteri Ekleme";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// frmSatis
			// 
			AcceptButton = btnEkle;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(1063, 659);
			Controls.Add(panel1);
			Controls.Add(lblGenelToplam);
			Controls.Add(label9);
			Controls.Add(btnSatışYap);
			Controls.Add(btnSatışİptal);
			Controls.Add(btnSil);
			Controls.Add(btnEkle);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			Name = "frmSatis";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Satış Sayfası";
			Load += frmSatis_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox txtTelefon;
		private TextBox txtAdSoyad;
		private TextBox txtTc;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private TextBox txtToplamFiyat;
		private TextBox txtSatışFiyatı;
		private TextBox txtMiktar;
		private TextBox txtÜrünAdı;
		private TextBox txtBarkodNo;
		private Button btnEkle;
		private Button btnSil;
		private Button btnSatışİptal;
		private Button btnSatışYap;
		private Label label9;
		private Label lblGenelToplam;
		private Panel panel1;
		private Button button9;
		private Button button8;
		private Button button7;
		private Button button6;
		private Button button5;
		private Button button2;
		private Button button1;
	}
}
