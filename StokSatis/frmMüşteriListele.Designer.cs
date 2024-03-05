namespace StokSatis
{
	partial class frmMüşteriListele
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
			btnGüncelle = new Button();
			txtEmail = new TextBox();
			txtAdres = new TextBox();
			txtTelefon = new TextBox();
			txtAdSoyad = new TextBox();
			txtTc = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnSil = new Button();
			txtTcAra = new TextBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(395, 102);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(729, 474);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
			// 
			// btnGüncelle
			// 
			btnGüncelle.Location = new Point(176, 438);
			btnGüncelle.Name = "btnGüncelle";
			btnGüncelle.Size = new Size(127, 60);
			btnGüncelle.TabIndex = 21;
			btnGüncelle.Text = "Güncelle";
			btnGüncelle.UseVisualStyleBackColor = true;
			btnGüncelle.Click += btnGüncelle_Click;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(126, 405);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(244, 27);
			txtEmail.TabIndex = 20;
			// 
			// txtAdres
			// 
			txtAdres.Location = new Point(126, 349);
			txtAdres.Name = "txtAdres";
			txtAdres.Size = new Size(244, 27);
			txtAdres.TabIndex = 19;
			// 
			// txtTelefon
			// 
			txtTelefon.Location = new Point(126, 293);
			txtTelefon.Name = "txtTelefon";
			txtTelefon.Size = new Size(244, 27);
			txtTelefon.TabIndex = 18;
			// 
			// txtAdSoyad
			// 
			txtAdSoyad.Location = new Point(126, 237);
			txtAdSoyad.Name = "txtAdSoyad";
			txtAdSoyad.Size = new Size(244, 27);
			txtAdSoyad.TabIndex = 17;
			// 
			// txtTc
			// 
			txtTc.Location = new Point(126, 181);
			txtTc.Name = "txtTc";
			txtTc.Size = new Size(244, 27);
			txtTc.TabIndex = 16;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(21, 412);
			label5.Name = "label5";
			label5.Size = new Size(52, 20);
			label5.TabIndex = 15;
			label5.Text = "E-Mail";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 356);
			label4.Name = "label4";
			label4.Size = new Size(47, 20);
			label4.TabIndex = 14;
			label4.Text = "Adres";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 300);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 13;
			label3.Text = "Telefon";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 244);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 12;
			label2.Text = "Ad Soyad";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 188);
			label1.Name = "label1";
			label1.Size = new Size(25, 20);
			label1.TabIndex = 11;
			label1.Text = "TC";
			// 
			// btnSil
			// 
			btnSil.Location = new Point(176, 520);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(127, 56);
			btnSil.TabIndex = 22;
			btnSil.Text = "Silme";
			btnSil.UseVisualStyleBackColor = true;
			btnSil.Click += btnSil_Click;
			// 
			// txtTcAra
			// 
			txtTcAra.Location = new Point(126, 102);
			txtTcAra.Name = "txtTcAra";
			txtTcAra.Size = new Size(244, 27);
			txtTcAra.TabIndex = 23;
			txtTcAra.TextChanged += txtTcAra_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 102);
			label6.Name = "label6";
			label6.Size = new Size(73, 20);
			label6.TabIndex = 24;
			label6.Text = "TC Arama";
			// 
			// frmMüşteriListele
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(1149, 661);
			Controls.Add(label6);
			Controls.Add(txtTcAra);
			Controls.Add(btnSil);
			Controls.Add(btnGüncelle);
			Controls.Add(txtEmail);
			Controls.Add(txtAdres);
			Controls.Add(txtTelefon);
			Controls.Add(txtAdSoyad);
			Controls.Add(txtTc);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Name = "frmMüşteriListele";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Müşteri Listeleme Sayfası";
			Load += frmMüşteriListele_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button btnGüncelle;
		private TextBox txtEmail;
		private TextBox txtAdres;
		private TextBox txtTelefon;
		private TextBox txtAdSoyad;
		private TextBox txtTc;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button btnSil;
		private TextBox txtTcAra;
		private Label label6;
	}
}