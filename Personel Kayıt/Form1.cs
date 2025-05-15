using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
namespace Personel_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Bağlantı Yolunun Oluşturulması
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0B1GIRL;Initial Catalog=Denemem;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ///**********************************************
                //Veri tabanı parametrelerine kayıt ekleme  /////
                //INSERT INTO Veri Ekleme (INSERT)          /////
                ///**********************************************
                string vt_kayit = "INSERT INTO kayit_personel (ad,soyad) VALUES (@ad,@soyad)";
                SqlCommand parametreler = new SqlCommand(vt_kayit, connection);
                parametreler.Parameters.AddWithValue("@ad", txtAd.Text);
                parametreler.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                connection.Open();
                parametreler.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex);
            }
            finally
            {

                connection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataGridView de Verileri Gösterme
            string sorgu = "SELECT * From kayit_personel";//Tablomuzu DataGridView ile ilişkilendirdik
            SqlDataAdapter tabloyu = new SqlDataAdapter(sorgu, connection);//Tablomuza Bağlandık
            DataTable tablom = new DataTable();//Tablomuzdaki Verileri okuttuk
            try
            {
                connection.Open();
                tabloyu.Fill(tablom);//Veriler, Tablomdan Çek
                dataGridView1.DataSource = tablom;//DataGridView e Aktar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelleUpdate_Click(object sender, EventArgs e)
        {
            string guncelle = "UPDATE kayit_personel SET ad=@ad,soyad=@soyad WHERE id=@id";//Where @id ye göre güncelle
            SqlCommand cmd = new SqlCommand(guncelle, connection);//guncelle stringi ve connection veri tabanını güncelleme
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@id", txtid.Text);//id ye göre güncelleme işlemi yapıldı
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();//Verileri Güncelleme ve Ekleme
                MessageBox.Show("Veriler Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);

            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Delete Silme İşlemi
            string sil = "DELETE FROM kayit_personel WHERE id=@id";//id ye göre silme
            SqlCommand sqlCommand = new SqlCommand(sil, connection);
            sqlCommand.Parameters.AddWithValue("@id",txtid.Text);

            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();//Veri kayıt Güncelleme ve Sillme işlemleri için
                MessageBox.Show("Silme işlemi başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata" + ex);
            }
            finally 
            {
                connection.Close();
            }
        }
    }
}
