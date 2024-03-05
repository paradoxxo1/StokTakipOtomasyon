using System.Data;
using System.Data.SqlClient;

namespace StokSatis
{
	public partial class frmSatışListele : Form
	{
		public frmSatışListele()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-14O3UCL\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
		DataSet daset = new DataSet();
		private void satışlistele()
		{
			baglanti.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("select * from satis ", baglanti);
			adtr.Fill(daset, "satis");
			dataGridView1.DataSource = daset.Tables["sepet"];

			baglanti.Close();
		}

		private void frmSatışListele_Load(object sender, EventArgs e)
		{
			satışlistele();
		}
	}
}
