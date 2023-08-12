using SınavDAL;
using SınavEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Hatırlatıcı
{
    public partial class Form1 : Form
    {
        DataContext db=new DataContext();
        Sınavlar sınav=new Sınavlar();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Sınav_adı != null && txt_tarih != null)
            {
                sınav.sınav_adı = txt_Sınav_adı.Text;
                sınav.tarihi = txt_tarih.Text;
                sınav.saati = txt_saat.Text;
                sınav.dakika = txt_dakika.Text;

                db.Set<Sınavlar>().Add(sınav);
                db.SaveChanges();

                dataGridView1.DataSource=db.Set<Sınavlar>().ToList();

                txt_Sınav_adı.Text="";
                txt_tarih.Text = "";
                txt_saat.Text = "";
                txt_dakika.Text = "";

                MessageBox.Show("Sınav günü kaydedildi!");
            }
            else
            {
                MessageBox.Show("Hata!");
            }

        }

        private void btn_yaklaşan_sınavlar_Click(object sender, EventArgs e)
        {

            //var müzik = db.Set<Sınavlar>().Where(i => i.saati == DateTime.Now.Hour.ToString()).FirstOrDefault();
            //if(müzik!= null)
            //{
            //    axWindowsMediaPlayer1.URL = "C:\\Users\\Maksut\\OneDrive\\Masaüstü\\Müzik";
            //    //if(axWindowsMediaPlayer1.URL == "C:\\Users\\Maksut\\OneDrive\\Masaüstü\\Müzik")
            //    //{
                    
            //    //}
            //}

            dataGridView1.DataSource = db.Set<Sınavlar>().ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txt_ID.Text);

            var sil=db.Set<Sınavlar>().Where(i=>i.ID==id).FirstOrDefault();

            if(sil!= null)
            {
                db.Set<Sınavlar>().Remove(sil);
                db.SaveChanges();
                dataGridView1.DataSource = db.Set<Sınavlar>().ToList();
                txt_ID.Clear();
                MessageBox.Show("Veri silindi!");
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txt_ID.Text);
            var güncelle=db.Set<Sınavlar>().Where(i=>i.ID==id).FirstOrDefault();
            if (güncelle != null)
            {
                güncelle.sınav_adı = txt_Sınav_adı.Text;
                güncelle.tarihi = txt_tarih.Text;
                güncelle.saati=txt_saat.Text;
                güncelle.dakika = txt_dakika.Text;

                
                db.SaveChanges();

                dataGridView1.DataSource = db.Set<Sınavlar>().ToList();

                MessageBox.Show("Güncelleme gerçekleşti!");
            }
            else
            {
                MessageBox.Show("Hata!");
            }
        }
    }
}
