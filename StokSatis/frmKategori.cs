using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmKategori : Form
	{
		public frmKategori()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");

		bool durum;
		private void kategorikontrol()
		{
			durum = true;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
			SqlDataReader read = komut.ExecuteReader();
			while (read.Read())
			{
				if (textBox1.Text == read["kategori"].ToString() || textBox1.Text == "")
				{
					durum = false;
				}
			}
			baglanti.Close();
		}

		private void frmKategori_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			kategorikontrol();
			if (durum == true)
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "')", baglanti);
				komut.ExecuteNonQuery();
				baglanti.Close();
				MessageBox.Show("Kategori Eklenmiştir");
			}
			else
			{
				MessageBox.Show("Böyle bir kategori var", "Uyarı");
			}
			textBox1.Text = "";


		}
	}
}
