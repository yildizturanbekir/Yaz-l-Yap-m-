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
    public partial class KelimeCevap : Form
    {
        public KelimeCevap()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Ezber;Integrated Security=SSPI");
        string kelimeTıklanan;      
        int chck1, chck2, chck3, chck4, dogruCevap;
        private void KelimeCevap_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm fMenu = new MenuForm();
            fMenu.Show();
        }

        private void KelimeCevap_Load(object sender, EventArgs e)
        {           
            ListboxEkle();// form load olurken kelimeleri list box a eklıyor
        }
        
        // butonlara basılınca kelimenin kontrolunu yapıp işlem yapdırıyoruz

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();    
            SqlCommand cmd = new SqlCommand("select Count(*) from Kelime where Dogru_Cevap = @kel2 and Kelime=@kel",conn);
            cmd.Parameters.AddWithValue("@kel",kelimeTıklanan);
            cmd.Parameters.AddWithValue("@kel2",btnA.Text);
            dogruCevap = (int)cmd.ExecuteScalar();
            CevapKontrol();
            conn.Close();
            Temizle();
            ListboxEkle();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) from Kelime where Dogru_Cevap = @kel2 and Kelime=@kel", conn);
            cmd.Parameters.AddWithValue("@kel", kelimeTıklanan);
            cmd.Parameters.AddWithValue("@kel2", btnC.Text);
            dogruCevap = (int)cmd.ExecuteScalar();
            CevapKontrol();
            conn.Close();
            Temizle();
            ListboxEkle();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) from Kelime where Dogru_Cevap = @kel2 and Kelime=@kel", conn);
            cmd.Parameters.AddWithValue("@kel", kelimeTıklanan);
            cmd.Parameters.AddWithValue("@kel2", btnB.Text);
            dogruCevap = (int)cmd.ExecuteScalar();
            CevapKontrol();
            conn.Close();
            Temizle();
            ListboxEkle();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) from Kelime where Dogru_Cevap = @kel2 and Kelime=@kel", conn);
            cmd.Parameters.AddWithValue("@kel", kelimeTıklanan);
            cmd.Parameters.AddWithValue("@kel2", btnD.Text);
            dogruCevap = (int)cmd.ExecuteScalar();
            CevapKontrol();
            conn.Close();
            Temizle();
            ListboxEkle();
        }

        private void ListboxEkle()
        {
            LbxKelime.Items.Clear();
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            string tarih1 = tarih.ToString();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Kelime FROM Kelime WHERE (Kelime_1gun=@tar and check1='0')or" +
               " (Kelime_1hafta=@tar and check2='0') or(Kelime_1ay=@tar and check3='0') or " +
                    "(Kelime_6ay=@tar and Kelime_Ok='0')", conn);
            cmd.Parameters.AddWithValue("@tar", tarih1);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                LbxKelime.Items.Add(rdr["Kelime"]);
            }
            conn.Close();
            if(LbxKelime.Items.Count<=0)//list boxta eleman kalmayınca bizi ana forma gonderiyor
            {
                MessageBox.Show("Tebrikler Butun Kelimeleri bitirdiniz.","Mesaj");
                this.Close();
            }
        }

        // list box a veri cekiyoruz
        private void LbxKelime_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKelime.Text = "Kelime: ";
            lblCumle.Text = "Cumle: ";
            string veriTiklanan = LbxKelime.SelectedItem.ToString();
            kelimeTıklanan = LbxKelime.SelectedItem.ToString();
            lblKelime.Text += veriTiklanan;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kelime WHERE Kelime=@Kel", conn);
            cmd.Parameters.AddWithValue("@Kel", veriTiklanan);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblCumle.Text += rdr["Kelime_Cumle"].ToString();
                btnA.Text = rdr["Kelime_cvp1"].ToString();
                btnB.Text = rdr["Kelime_cvp2"].ToString();
                btnC.Text = rdr["Kelime_cvp3"].ToString();
                btnD.Text = rdr["Kelime_cvp4"].ToString();
            }
            conn.Close();

            

        }
        //soruya cevap verdikten sonra yeni soru için temizleme işlemi yapıyoruz
        private void Temizle()
        {
            lblKelime.Text = "Kelime: ";
            lblCumle.Text = "Cumle: ";
            btnA.Text = "";
            btnB.Text ="";
            btnC.Text = "";
            btnD.Text = "";
        }
        //Sorunun dogru olup olmadıgını kontrol ettiriyoruz
        private void CevapKontrol()
        {
            if (dogruCevap > 0)
            {
                int moon = DateTime.Now.Month;
                SqlCommand Komut1 = new SqlCommand("select * from Kelime where Kelime=@kel2", conn);
                Komut1.Parameters.AddWithValue("@kel2", kelimeTıklanan);
                SqlDataReader rdr = Komut1.ExecuteReader();
                while (rdr.Read())
                {

                    chck1 = Convert.ToInt16(rdr["check1"].ToString());
                    chck2 = Convert.ToInt16(rdr["check2"].ToString());
                    chck3 = Convert.ToInt16(rdr["check3"].ToString());
                    chck4 = Convert.ToInt16(rdr["Kelime_Ok"].ToString());
                }
                rdr.Close();
                if (chck1 == 0 && chck2 == 0 && chck3 == 0 && chck4 == 0)
                {
                    SqlCommand komut = new SqlCommand("update Kelime set check1='1' where Kelime=@kel", conn);
                    komut.Parameters.AddWithValue("@kel", kelimeTıklanan);
                    komut.ExecuteNonQuery();

                }
                else if (chck1 == 1 && chck2 == 0 && chck3 == 0 && chck4 == 0)
                {
                    SqlCommand komut = new SqlCommand("update Kelime set check2='1' where Kelime=@kel", conn);
                    komut.Parameters.AddWithValue("@kel", kelimeTıklanan);
                    komut.ExecuteNonQuery();

                }
                else if (chck1 == 1 && chck2 == 1 && chck3 == 0 && chck4 == 0)
                {
                    SqlCommand komut = new SqlCommand("update Kelime set check3='1' where Kelime=@kel", conn);
                    komut.Parameters.AddWithValue("@kel", kelimeTıklanan);
                    komut.ExecuteNonQuery();

                }
                else if (chck1 == 1 && chck2 == 1 && chck3 == 1 && chck4 == 0)
                {
                    SqlCommand komut = new SqlCommand("update Kelime set Kelime_Ok='1',Kelime_Tamam=@ay,Kelime_Yıl=@yıl where Kelime=@kel", conn);
                    komut.Parameters.AddWithValue("@kel", kelimeTıklanan);
                    komut.Parameters.AddWithValue("@ay",moon.ToString());
                    komut.Parameters.AddWithValue("@yıl",DateTime.Now.Year.ToString());
                    komut.ExecuteNonQuery();

                }

            }
            else
            {
                MessageBox.Show("Yanlış Cevap girdiniz.<<Süreç sıfırlandı>>", "Uyarı");
            
                DateTime tarih = new DateTime();
                tarih = DateTime.Today;
                string tarih1 = tarih.ToString();
                SqlCommand komut3 = new SqlCommand("Update Kelime set Kelime_1gun=@tar1,check1='0',Kelime_1hafta=@tar2, check2='0',Kelime_1ay=@tar3, check3='0',Kelime_6ay=@tar4, Kelime_Ok='0'" +
                   " where Kelime=@kel ", conn);
                komut3.Parameters.AddWithValue("@kel", kelimeTıklanan);
                komut3.Parameters.AddWithValue("@tar1", tarih.AddDays(1).ToString());
                komut3.Parameters.AddWithValue("@tar2", tarih.AddDays(7).ToString());
                komut3.Parameters.AddWithValue("@tar3", tarih.AddMonths(1).ToString());
                komut3.Parameters.AddWithValue("@tar4", tarih.AddMonths(6).ToString());
                komut3.ExecuteNonQuery();
               
            }
        }
    }
}
