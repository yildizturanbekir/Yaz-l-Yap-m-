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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Db_Ezber;Integrated Security=SSPI");
        int toplamOgrenilen,toplam;
        private void RaporForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuForm fMenu = new MenuForm();
            fMenu.Show();
        }

        // form load olurken chart ların gornurlunu ve titleisini eklıyoruz
        private void RaporForm_Load(object sender, EventArgs e)
        {        
            cmbxSecim.SelectedIndex = 2;
            chrtAylık.Visible = false;
            chrtYıllık.Visible = false;
            this.chrtYıllık.Titles.Add("Son 5 Yılın Öğrenilen Kelime Sayısı");
            this.chrtAylık.Titles.Add("Aylara Göre Öğrenilen Kelime Karşılaştırması (%)");
            label2.Text = "";
        }

        // combobox ta secilen value gore ayar yapıyoruz
       private void cmbxSecim_SelectedIndexChanged(object sender, EventArgs e)
       {
            string secim = cmbxSecim.SelectedItem.ToString();
            if (secim == "Aylık")
            {
                chrtYıllık.Visible = false;
                chrtAylık.Visible=true;
                AylıkVeriGetir();                
            }
            else if (secim == "Yıllık")
            {
                chrtAylık.Visible = false;
                chrtYıllık.Visible = true;
                ChrtYıllıkDoldur();
            }
       }

        //chart Nesnelerinin içini doluran fonksiyolar 
        private void AylıkVeriGetir()
        {
            int yıl = DateTime.Now.Year;
            string tarih1, tarih2;
            tarih1="01.01."+yıl ;
            tarih2 = "31.12." + yıl ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Kelime where  Kelime_6ay between @tar1 and @tar2 and Kelime_Ok='1'", conn);
            cmd.Parameters.AddWithValue("@tar1",tarih1);
            cmd.Parameters.AddWithValue("@tar2", tarih2);
            toplamOgrenilen = (int)cmd.ExecuteScalar();
            conn.Close();
            if(toplamOgrenilen>0)
            {
                ChrtAylıkDoldur();
            }
            else
            {
                MessageBox.Show("Bu yıl kelime tamamlamadınız daha","Uyarı");
            }
        }

        private void ChrtAylıkDoldur()
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='04'", conn);
            int deger = (int)komut.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(4, deger * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='05'", conn);
            int deger1 = (int)komut1.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(05, deger1 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='06'", conn);
            int deger2 = (int)komut2.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(06, deger2 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='07'", conn);
            int deger3 = (int)komut3.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(07, deger3 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut4 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='08'", conn);
            int deger4 = (int)komut4.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(08, deger4 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut5 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='09'", conn);
            int deger5 = (int)komut5.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(09, deger5 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut6 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='10'", conn);
            int deger6 = (int)komut6.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(10, deger6 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut7 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='11'", conn);
            int deger7 = (int)komut7.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(11, deger7 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut8 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='12'", conn);
            int deger8 = (int)komut8.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(12, deger8 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut9 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='01'", conn);
            int deger9 = (int)komut9.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(01, deger9 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut10 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='02'", conn);
            int deger10 = (int)komut10.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(02, deger10 * 100 / toplamOgrenilen);
            conn.Close();

            conn.Open();
            SqlCommand komut11 = new SqlCommand("Select count(*) from Kelime where  Kelime_tamam='03'", conn);
            int deger11 = (int)komut11.ExecuteScalar();
            this.chrtAylık.Series["Aylar"].Points.AddXY(03, deger11 * 100 / toplamOgrenilen);
            conn.Close();
            label2.Text = "Toplam kelime: "+(deger+deger1+ deger2 + deger3 + deger4 + deger5 + deger6 + deger7 + deger8 + deger9 + deger10 + deger11);

        }
        
        private void ChrtYıllıkDoldur()
        {
            int yıl = DateTime.Now.Year;

            conn.Open();
            SqlCommand komut1 = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl>=0", conn);
            int yılTum = (int)komut1.ExecuteScalar();            
            conn.Close();

            conn.Open();            
            SqlCommand cmd = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl=@tar1 and Kelime_Ok='1'", conn);
            cmd.Parameters.AddWithValue("@tar1",yıl);
            int yıllıkOgrenilen = (int)cmd.ExecuteScalar();
            this.chrtYıllık.Series["Yıllık"].Points.AddXY(yıl, yıllıkOgrenilen * 100 / yılTum );
            conn.Close();

            conn.Open();
            yıl = yıl - 1;
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl=@tar1 and Kelime_Ok='1'", conn);
            cmd1.Parameters.AddWithValue("@tar1",yıl);            
            int yıllıkOgrenilen1 = (int)cmd1.ExecuteScalar();
            this.chrtYıllık.Series["Yıllık"].Points.AddXY(yıl, yıllıkOgrenilen1 * 100 / yılTum);
            conn.Close();

            conn.Open();
            yıl = yıl - 1;
            SqlCommand cmd2 = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl=@tar1 and Kelime_Ok='1'", conn);
            cmd2.Parameters.AddWithValue("@tar1", yıl);
            int yıllıkOgrenilen2 = (int)cmd2.ExecuteScalar();
            this.chrtYıllık.Series["Yıllık"].Points.AddXY(yıl, yıllıkOgrenilen2 * 100 / yılTum);
            conn.Close();

            conn.Open();
            yıl = yıl - 1;
            SqlCommand cmd3 = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl=@tar1 and Kelime_Ok='1'", conn);
            cmd3.Parameters.AddWithValue("@tar1", yıl);
            int yıllıkOgrenilen3 = (int)cmd3.ExecuteScalar();
            this.chrtYıllık.Series["Yıllık"].Points.AddXY(yıl, yıllıkOgrenilen3 * 100 / yılTum);
            conn.Close();

            conn.Open();
            yıl = yıl - 1;
            SqlCommand cmd4 = new SqlCommand("Select count(*) from Kelime where  Kelime_Yıl=@tar1 and Kelime_Ok='1'", conn);
            cmd4.Parameters.AddWithValue("@tar1", yıl);
            int yıllıkOgrenilen4 = (int)cmd4.ExecuteScalar();
            this.chrtYıllık.Series["Yıllık"].Points.AddXY(yıl, yıllıkOgrenilen4 * 100 / yılTum);
            conn.Close();

            label2.Text ="Toplam Kelime :"+(yıllıkOgrenilen+yıllıkOgrenilen1+yıllıkOgrenilen2+yıllıkOgrenilen3+yıllıkOgrenilen4);
        }
    }
}
