using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmMarka : Form
	{
		public frmMarka()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");


		bool durum;
		private void markakontrol()
		{
			durum = true;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from markabilgileri", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				if (comboBox1.Text == read ["kategori"].ToString() && textBox1.Text == read["marka"].ToString() || comboBox1.Text == "" ||textBox1.Text == "")
				{
					durum = false;
				}
			}
			baglanti.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			markakontrol();
			if (durum == true)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);
				komut.ExecuteNonQuery();
				MessageBox.Show("Marka Eklenmiştir");
			}
			else
			{
				MessageBox.Show("Böyle bir kategori ve marka var", "Uyarı");
			}

			baglanti.Close();
			textBox1.Text = "";

		}

		private void kategorigetir()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				comboBox1.Items.Add(read["kategori"].ToString());
			}
			baglanti.Close();
		}

		private void frmMarka_Load(object sender, EventArgs e)
		{
			kategorigetir();
		}
	}
}
