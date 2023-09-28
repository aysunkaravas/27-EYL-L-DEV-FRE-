using System.Drawing;
using System.Security.Policy;

namespace _27_EYLÜL_ÖDEV_ŞİFRE_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

        private void textSifreGir_TextChanged(object sender, EventArgs e)
        {
            string sifre;
            sifre = textSifreGir.Text;



            string harfler = "abcçdefgğhıijklmnoöprsştuüvyzABCÇDEFGĞHIİLJKMNOÖPRSŞTUÜVYZ";
            string sayılar = "1234567890";
            string özelkarakter = "*?/#%&'!-+@ ";


            bool harfMi = false;
            bool sayiMi = false;
            bool özelKarakterMi = false;


            if(sifre.Length < 6)
            {
                lblsifreKontrol.Text = "Zayıf";
                lblsifreKontrol.BackColor = Color.Red;
            }

            foreach (char item in sifre)
            {


                if (harfler.IndexOf(item) != -1)
                {

                    harfMi = true;

                }

                if (sayılar.IndexOf(item) != -1)
                {
                    sayiMi = true;

                }


                if (özelkarakter.IndexOf(item) != -1) 
                {
                    özelKarakterMi = true;
                }
            }

            if(harfMi==true&& sayiMi==true && özelKarakterMi==true)
            {
                lblsifreKontrol.Text = "Güçlü";
                lblsifreKontrol.BackColor = Color.Green;
            }
            
            else if(harfMi==true && sayiMi==true || harfMi==true&& özelKarakterMi==true || özelKarakterMi==true && sayiMi==true)
            {
                lblsifreKontrol.Text = "Orta";
                lblsifreKontrol.BackColor = Color.Blue;
            }


                else
            {
                lblsifreKontrol.Text = "Zayıf";
                lblsifreKontrol.BackColor = Color.Red;
            }    



                         
            




           
        }
        
      

       

    }
}