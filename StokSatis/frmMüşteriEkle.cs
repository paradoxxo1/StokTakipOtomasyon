using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmMüşteriEkle : Form
	{
		public frmMüşteriEkle()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");


		private void frmMüşteriEkle_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into müşteri(tc, adsoyad, telefon, adres,email) values(@tc, @adsoyad, @telefon, @adres,@email)", baglanti);
			komut.Parameters.AddWithValue("@tc", txtTc.Text);
			komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
			komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
			komut.Parameters.AddWithValue("@adres", txtAdres.Text);
			komut.Parameters.AddWithValue("@email", txtEmail.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Müşteri kaydı eklendi");
			foreach (Control item in this.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}

			}
		}
	}
}
