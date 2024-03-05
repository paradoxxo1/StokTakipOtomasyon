namespace StokSatis
{
	partial class frmMüşteriEkle
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtTc = new TextBox();
			txtAdSoyad = new TextBox();
			txtTelefon = new TextBox();
			txtAdres = new TextBox();
			txtEmail = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(57, 94);
			label1.Name = "label1";
			label1.Size = new Size(25, 20);
			label1.TabIndex = 0;
			label1.Text = "TC";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(57, 150);
			label2.Name = "label2";
			label2.Size = new Size(73, 20);
			label2.TabIndex = 1;
			label2.Text = "Ad Soyad";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(57, 206);
			label3.Name = "label3";
			label3.Size = new Size(58, 20);
			label3.TabIndex = 2;
			label3.Text = "Telefon";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(57, 262);
			label4.Name = "label4";
			label4.Size = new Size(47, 20);
			label4.TabIndex = 3;
			label4.Text = "Adres";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(57, 318);
			label5.Name = "label5";
			label5.Size = new Size(52, 20);
			label5.TabIndex = 4;
			label5.Text = "E-Mail";
			// 
			// txtTc
			// 
			txtTc.Location = new Point(160, 87);
			txtTc.Name = "txtTc";
			txtTc.Size = new Size(244, 27);
			txtTc.TabIndex = 5;
			// 
			// txtAdSoyad
			// 
			txtAdSoyad.Location = new Point(160, 143);
			txtAdSoyad.Name = "txtAdSoyad";
			txtAdSoyad.Size = new Size(244, 27);
			txtAdSoyad.TabIndex = 6;
			// 
			// txtTelefon
			// 
			txtTelefon.Location = new Point(160, 199);
			txtTelefon.Name = "txtTelefon";
			txtTelefon.Size = new Size(244, 27);
			txtTelefon.TabIndex = 7;
			// 
			// txtAdres
			// 
			txtAdres.Location = new Point(160, 255);
			txtAdres.Name = "txtAdres";
			txtAdres.Size = new Size(244, 27);
			txtAdres.TabIndex = 8;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(160, 311);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(244, 27);
			txtEmail.TabIndex = 9;
			// 
			// button1
			// 
			button1.Location = new Point(209, 344);
			button1.Name = "button1";
			button1.Size = new Size(127, 60);
			button1.TabIndex = 10;
			button1.Text = "Ekle";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// frmMüşteriEkle
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(483, 440);
			Controls.Add(button1);
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
			Name = "frmMüşteriEkle";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Müşteri Ekleme Sayfası";
			Load += frmMüşteriEkle_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtTc;
		private TextBox txtAdSoyad;
		private TextBox txtTelefon;
		private TextBox txtAdres;
		private TextBox txtEmail;
		private Button button1;
	}
}