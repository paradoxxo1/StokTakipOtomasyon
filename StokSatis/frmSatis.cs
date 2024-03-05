using System.Data;
using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmSatis : Form
	{
		public frmSatis()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
		DataSet daset = new DataSet();
		private void sepetlistele()
		{
			baglanti.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet ", baglanti);
			adtr.Fill(daset, "sepet");
			dataGridView1.DataSource = daset.Tables["sepet"];
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].Visible = false;
			dataGridView1.Columns[2].Visible = false;
			baglanti.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			frmMüþteriEkle ekle = new frmMüþteriEkle();
			ekle.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			frmMüþteriListele listele = new frmMüþteriListele();
			listele.ShowDialog();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			frmÜrünEkle ekle = new frmÜrünEkle();
			ekle.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmKategori kategori = new frmKategori();
			kategori.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmMarka marka = new frmMarka();
			marka.ShowDialog();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			frmÜrünListele listele = new frmÜrünListele();
			listele.ShowDialog();

		}
		private void hesapla()
		{
			try
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("select sum (toplamfiyati) from sepet", baglanti);
				lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
				baglanti.Close();
			}
			catch (Exception)
			{

				;
			}
		}

		private void frmSatis_Load(object sender, EventArgs e)
		{
			sepetlistele();
		}

		private void txtTc_TextChanged(object sender, EventArgs e)
		{
			if (txtTc.Text == "")
			{
				txtAdSoyad.Text = "";
				txtTelefon.Text = "";
			}
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from müþteri where tc like '" + txtTc.Text + "'", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				txtAdSoyad.Text = read["adsoyad"].ToString();
				txtTelefon.Text = read["telefon"].ToString();
			}
			baglanti.Close();
		}

		private void txtBarkod_TextChanged(object sender, EventArgs e)
		{
			Temizle();
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from urun where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				txtÜrünAdý.Text = read["urunadi"].ToString();
				txtSatýþFiyatý.Text = read["satisfiyati"].ToString();
			}
			baglanti.Close();

		}

		private void Temizle()
		{
			if (txtBarkodNo.Text == "")
			{
				foreach (Control item in groupBox2.Controls)
				{
					if (item is TextBox)
					{
						if (item != txtMiktar)
						{
							item.Text = "";

						}

					}

				}

			}
		}

		bool durum;
		private void barkodKontrol()
		{
			durum = true;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from sepet", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				if (txtBarkodNo.Text == read["barkodno"].ToString())
				{
					durum = false;
				}

			}
			baglanti.Close();


		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			barkodKontrol();
			if (durum == true)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into sepet(tc, adsoyad, telefon, barkodno, urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);

				komut.Parameters.AddWithValue("@tc", txtTc.Text);
				komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
				komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
				komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
				komut.Parameters.AddWithValue("@urunadi", txtÜrünAdý.Text);
				komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
				komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatýþFiyatý.Text));
				komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
				komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
				komut.ExecuteNonQuery();
				baglanti.Close();
			}
			else
			{
				baglanti.Open();
				SqlCommand komut2 = new SqlCommand("UPDATE sepet SET miktari = miktari + @miktar WHERE barkodno = @barkodno", baglanti);
				komut2.Parameters.AddWithValue("@miktar", int.Parse(txtMiktar.Text));
				komut2.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
				komut2.ExecuteNonQuery();

				SqlCommand komut3 = new SqlCommand("UPDATE sepet SET toplamfiyati = miktari * satisfiyati WHERE barkodno = @barkodno", baglanti);
				komut3.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
				komut3.ExecuteNonQuery();

				baglanti.Close();
			}
			txtMiktar.Text = "1";
			daset.Tables["sepet"].Clear();
			sepetlistele();
			hesapla();

			foreach (Control item in groupBox2.Controls)
			{
				if (item is TextBox)
				{
					if (item != txtMiktar)
					{
						item.Text = "";

					}

				}

			}

		}

		private void txtMiktar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double miktar, satisFiyati;
				if (double.TryParse(txtMiktar.Text, out miktar) && double.TryParse(txtSatýþFiyatý.Text, out satisFiyati))
				{
					double toplamFiyat = miktar * satisFiyati;
					txtToplamFiyat.Text = toplamFiyat.ToString();
				}
				else
				{
					MessageBox.Show("Geçerli bir sayýsal deðer giriniz. Ya da Önce Barkod numarasý seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from sepet where barkodno ='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Ürün sepetten çýkarýlmýþtýr.");
			daset.Tables["sepet"].Clear();
			sepetlistele();
			hesapla();
		}

		private void btnSatýþÝptal_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Ürün sepeti temizlenmiþtir.");
			daset.Tables["sepet"].Clear();
			sepetlistele();
			hesapla();

		}

		private void button9_Click(object sender, EventArgs e)
		{
			frmSatýþListele listele = new frmSatýþListele();
			listele.ShowDialog();
		}

		private void btnSatýþYap_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into satis(tc, adsoyad, telefon, barkodno, urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc, @adsoyad, @telefon, @barkodno, @urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);

				komut.Parameters.AddWithValue("@tc", txtTc.Text);
				komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
				komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
				komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
				komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
				komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
				komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
				komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
				komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
				komut.ExecuteNonQuery();

				SqlCommand komut2 = new SqlCommand("UPDATE urun SET miktari = miktari - @miktar WHERE barkodno = @barkodno", baglanti);

				komut2.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
				komut2.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
				komut2.ExecuteNonQuery();
				baglanti.Close();

			}

			baglanti.Open();
			SqlCommand komut3 = new SqlCommand("delete from sepet ", baglanti);
			komut3.ExecuteNonQuery();
			baglanti.Close();
			daset.Tables["sepet"].Clear();
			sepetlistele();
			hesapla();
		}
	}
}