using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmÜrünEkle : Form
	{
		public frmÜrünEkle()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");

		bool durum;
		private void barkodkontrol()
		{
			durum = true;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from urun", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text == "")
				{
					durum = false;
				}
			}
			baglanti.Close();
		}

		private void kategorigetir()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				comboKategori.Items.Add(read["kategori"].ToString());
			}
			baglanti.Close();
		}

		private void frmÜrünEkle_Load(object sender, EventArgs e)
		{
			kategorigetir();
		}

		private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
		{

			comboMarka.Items.Clear();
			comboMarka.Text = "";
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				comboMarka.Items.Add(read["marka"].ToString());
			}
			baglanti.Close();
		}

		private void btnYeniEkle_Click(object sender, EventArgs e)
		{
			barkodkontrol();
			if (durum == true)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into urun(barkodno, kategori, marka, urunadi, miktari, alisfiyati, satisfiyati, tarih) values(@barkodno, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati, @tarih)", baglanti);
				komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
				komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
				komut.Parameters.AddWithValue("@marka", comboMarka.Text);
				komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
				komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktarı.Text));
				komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlışFiyatı.Text));
				komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
				komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Ürün Ekleme Başarılı");
			}
			else
			{
				MessageBox.Show("Böyle bir barkodno var", "Uyarı");
			}
			comboMarka.Items.Clear();

			foreach (Control item in groupBox1.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}
				if (item is ComboBox)
				{
					item.Text = "";
				}

			}
		}

		private void BarkodNoTxt_TextChanged(object sender, EventArgs e)
		{

			if (BarkodNoTxt.Text == "")
			{
				lblMiktarı.Text = "";
				foreach (Control item in groupBox2.Controls)
				{
					if (item is TextBox)
					{
						item.Text = "";
					}

				}

			}
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from urun where barkodno like'" + BarkodNoTxt.Text + "'", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				KategoriTxt.Text = read["kategori"].ToString();
				MarkaTxt.Text = read["marka"].ToString();
				ÜrünAdıTxt.Text = read["urunadi"].ToString();
				lblMiktarı.Text = read["miktari"].ToString();
				AlışFiyatıTxt.Text = read["alisfiyati"].ToString();
				SatışFiyatıTxt.Text = read["satisfiyati"].ToString();
			}
			baglanti.Close();
		}

		private void btnVarOlanaEkle_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'" + int.Parse(MiktarıTxt.Text) + "' where barkodno='" + BarkodNoTxt.Text + "'", baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();

			foreach (Control item in groupBox2.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}

			}
			MessageBox.Show("Var olan ürüne ekleme yapıldı");
		}
	}
}
