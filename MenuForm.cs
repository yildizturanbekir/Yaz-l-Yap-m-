using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v._02
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Ezber;Integrated Security=SSPI");
        //her hangi bir veritanında Db_ezber e baglanmasını saglıyoruz 

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Uygulamadan cıkılmasınız saglıyoruz X e basınca
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KelimeKayit fkayit = new KelimeKayit();// kayıt ekranının acılmasını saglıyoruz
            fkayit.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Guncelle();//ilk once guncelle calısaak sonra kontrol calısacak
            Kontrol();// fonksiyonu çagırıyoruz
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KelimeCevap fCevap = new KelimeCevap();// cevaplama ekranının acılmasını saglıyoruz
            fCevap.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RaporForm fRapor = new RaporForm();//rapor goruntuleme ekranın acılmasını saglıyoruz
            fRapor.Show();
            this.Hide();
        }


        // kontrol metodu Bu gün ne cevaplanması gereken bir kelime olup olmadığını kontrol ediyor varsa ekrane uyarı mesajı yoluyor
        private void Kontrol()
        {
            conn.Open();
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            string tarih1 = tarih.ToString();
            SqlCommand cmd = new SqlCommand("SELECT count(Kelime_id) FROM Kelime WHERE (Kelime_1gun=@tar and check1='0')or" +
                " (Kelime_1hafta=@tar and check2='0') or(Kelime_1ay=@tar and check3='0') or " +
                     "(Kelime_6ay=@tar and Kelime_Ok='0')", conn);
            cmd.Parameters.AddWithValue("@tar", tarih1);
            int toplamGorev = (int)cmd.ExecuteScalar();// Tek bir islem donduren kod
            if (toplamGorev != 0)
            {
               MessageBox.Show("Cevaplamanız gereken kelime sayısı : "+toplamGorev,"Uyarı");
            }
            else
            {
                btnCevapla.Enabled = false;
                btnCevapla.Text = "Cevaplanacak Kelime yok";
            }
            conn.Close();
        }
        private void Guncelle()//Suresi dolmus kelimeyi sıfırlama yaparak yeniden başa dondurecek
        {
            conn.Open();
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            string tarih1 = tarih.ToString();
            SqlCommand cmd = new SqlCommand("SELECT count(Kelime_id) FROM Kelime WHERE (Kelime_1gun<@tar and check1='0')or" +
                " (Kelime_1hafta<@tar and check2='0') or(Kelime_1ay<@tar and check3='0') or " +
                     "(Kelime_6ay<@tar and Kelime_Ok='0')", conn);
            cmd.Parameters.AddWithValue("@tar", tarih1);
            int Gorev = (int)cmd.ExecuteScalar();//Suresi Dolmuz kelime varsa gorev 0 dan buyuk olucak
            if (Gorev != 0)
            {
                
                SqlCommand komut = new SqlCommand("Update Kelime set Kelime_1gun=@tar1,check1='0',Kelime_1hafta=@tar2, check2='0',Kelime_1ay=@tar3, check3='0',Kelime_6ay=@tar4, Kelime_Ok='0'" +
                    " where (Kelime_1gun<@tar and check1='0')or(Kelime_1hafta<@tar and check2='0') or(Kelime_1ay<@tar and check3='0') or " +
                         "(Kelime_6ay<@tar and Kelime_Ok='0') ", conn);
                komut.Parameters.AddWithValue("@tar", tarih1);
                komut.Parameters.AddWithValue("@tar1", tarih.AddDays(1).ToString());
                komut.Parameters.AddWithValue("@tar2", tarih.AddDays(7).ToString());
                komut.Parameters.AddWithValue("@tar3", tarih.AddMonths(1).ToString());
                komut.Parameters.AddWithValue("@tar4", tarih.AddMonths(6).ToString());
                komut.ExecuteNonQuery();
                conn.Close();
            }
            conn.Close();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
