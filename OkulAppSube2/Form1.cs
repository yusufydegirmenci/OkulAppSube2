using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            // if(txtAd.Text==String.Empty && txtSoyad.Text==String.Empty && txtNumara.Text==String.Empty) 
            // {
            //    MessageBox.Show("TÜM ALANLAR ZORUNLUDUR.");
            //     return;
            // }

            bool kontrol = false;
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox && item.Text == String.Empty)
                {
                    item.BackColor = Color.Red;
                    kontrol = true;
                    
                }
            }

            if (kontrol) 
            { 
                MessageBox.Show("TÜM ALANLAR ZORUNLUDUR");
                return;
            } 
            SqlConnection cn = null;
            SqlCommand cmd = null;
            try
            {
                using (cn = new SqlConnection(@"Data Source=.\DESKTOP-RDAQ55L;Initial Catalog=OkulDbSube2;Integrated Security=true;
                   TrustServerCertificate=true"))
                {
                    using (cmd = new SqlCommand($"Insert into tblogrenciler values(@Ad,@Soyad,@Numara)", cn))
                    {
                        SqlParameter[] p =
                        {
                         new SqlParameter("@Ad",txt.Ad.Text.Trim()),
                         new SqlParameter("@Soyad", txt.Soyad.Text.Trim()),
                         new SqlParameter("@Numara", txt.Numara.Text.Trim()),
                        };
                        cmd.Parameters.AddRange(p);
                        if (cn != null && cn.State != ConnectionState.Open)
                        {
                            cn.Open();
                        }
                        int sonuc = cmd.ExecuteNonQuerry();
                        MessageBox.Show(sonuc > 0 ? "Ekleme Başaralı" : "Ekleme Başarısız...");
                    }
                }   
            }
            catch (Exception )
            {
                MessageBox.Show("Bir Hata Oluştu.");

            }
            //finally
            //{
            //    if (cn != null && cn.State != ConnectionState.Closed)
            //    {
            //        cn.Close();                   
            //        cmd.Dispose();
            //        cn.Dispose();
            //    }
            //}

         private void txt_TextChanged(object sender, EventArgs e)
         {
           TextBox textBox = (TextBox)sender;
           textBox.BackColor = Color.White;
               
                
                if (textBox.Text==String.Empty )
                {
                    textBox.BackColor = Color.Red;    
                }

         }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
