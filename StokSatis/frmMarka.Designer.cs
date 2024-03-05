namespace StokSatis
{
	partial class frmMarka
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
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			label2 = new Label();
			comboBox1 = new ComboBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(149, 148);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(188, 27);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(58, 151);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 1;
			label1.Text = "Marka";
			// 
			// button1
			// 
			button1.Location = new Point(195, 207);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Ekle";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(58, 91);
			label2.Name = "label2";
			label2.Size = new Size(66, 20);
			label2.TabIndex = 3;
			label2.Text = "Kategori";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(149, 88);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(188, 28);
			comboBox1.TabIndex = 4;
			// 
			// frmMarka
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(463, 348);
			Controls.Add(comboBox1);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "frmMarka";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Marka Sayfası";
			Load += frmMarka_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Button button1;
		private Label label2;
		private ComboBox comboBox1;
	}
}