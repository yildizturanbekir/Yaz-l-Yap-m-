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
    public partial class KelimeKayit : Form
    {
        public KelimeKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Ezber;Integrated Security=SSPI");
        private void KelimeKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MenuForm fMenu = new MenuForm();
            fMenu.Show();
        }

        private void KelimeKayit_Load(object sender, EventArgs e)
        {
            cmbxTur.SelectedIndex = 0;//combo box ilk değeri atıyoruz hata almamak için

        }


        private void Temizle()//temizle fonksiyonu kayıt ettikden sonra textbox ları bosaltıyor hazır hale getiriyor
        {
                 txtCevap1.Clear();
                 txtCevap2.Clear();
                 txtCevap3.Clear();
                 txtCevap4.Clear();
                 txtCumle.Clear();
                 txtInglizce.Clear();
                 txtTurkce.Clear();
                 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtCevap1.Text != "" && txtCevap2.Text != "" && txtCevap3.Text != "" && txtCevap4.Text != "" && txtInglizce.Text != "" && txtCumle.Text != "" && txtTurkce.Text != "")
            { //textboxların boş olup olmadıgını kontrol ettriyoruz
                if (txtTurkce.Text == txtCevap1.Text || txtTurkce.Text == txtCevap2.Text || txtTurkce.Text == txtCevap3.Text || txtTurkce.Text == txtCevap4.Text)
                    //Dogru cevap ile verilen cevapları karsılas tırıyoruz eger cevaplarda dogru yoksa işlem yapmıyoruz
                {
                    Kaydet();
                    Temizle();
                }
                else
                    MessageBox.Show("Cevaplardan biri <<<!Türkçe anlamı!>>> olmak zorunda","Uyarı");
                
            }
            else
            {
                MessageBox.Show("Boş yer bırakmayınız");
            }
        }

        private void Kaydet()
        {
            conn.Open();
            //Kelimeyi kayıt etmek ıcın gereken sql kodu
            SqlCommand cmd1 = new SqlCommand("select Count(*) from Kelime where Kelime=@Kel",conn);
            cmd1.Parameters.AddWithValue("@kel",txtInglizce.Text.ToLower());
            int kntl = (int)cmd1.ExecuteScalar();
            if (kntl == 0)
            {
                DateTime tarih = new DateTime();
                tarih = DateTime.Now.Date;
                SqlCommand cmd = new SqlCommand("insert into Kelime(Kelime,Kelime_cvp1,Kelime_cvp2,Kelime_cvp3,Kelime_cvp4," +
                "Dogru_Cevap,Kelime_Cumle,Kelime_Tur,check1,check2,check3,Kelime_Ok,Kelime_1gun,Kelime_1hafta,Kelime_1ay,Kelime_6ay)" +
                     "values(@Eng,@cvp1,@cvp2,@cvp3,@cvp4,@Dogru,@cumle,@tur,0,0,0,0,@gun,@hafta,@1ay,@6ay)", conn);
                cmd.Parameters.AddWithValue("@Eng", txtInglizce.Text.ToLower());
                cmd.Parameters.AddWithValue("@cvp1", txtCevap1.Text.ToLower());
                cmd.Parameters.AddWithValue("@cvp2", txtCevap2.Text.ToLower());
                cmd.Parameters.AddWithValue("@cvp3", txtCevap3.Text.ToLower());
                cmd.Parameters.AddWithValue("@cvp4", txtCevap4.Text.ToLower());
                cmd.Parameters.AddWithValue("@Dogru", txtTurkce.Text.ToLower());
                cmd.Parameters.AddWithValue("@cumle", txtCumle.Text);
                cmd.Parameters.AddWithValue("@tur", cmbxTur.SelectedItem);
                cmd.Parameters.AddWithValue("@gun", tarih.AddDays(1).ToString());
                cmd.Parameters.AddWithValue("@hafta", tarih.AddDays(7).ToString());
                cmd.Parameters.AddWithValue("@1ay", tarih.AddMonths(1).ToString());
                cmd.Parameters.AddWithValue("@6ay", tarih.AddMonths(6).ToString());
                cmd.ExecuteNonQuery();
            }
            else
                MessageBox.Show("Bu kelime zaten mevcut","Uyarı");            

            conn.Close();

        }
    }
}
