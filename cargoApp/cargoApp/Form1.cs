using System.Diagnostics.Metrics;
using static cargoApp.Form1;

namespace cargoApp


{

    public partial class Form1 : Form
    {

        int trLitrDeyer = 5;
        int trKgDeyer = 3;

        int waLitrDeyer = 10;
        int waKgDeyer = 13;

        int buLitrDeyer = 25;
        int buKgDeyer = 31;

        int kilogram;
        
        int qiymet;
        int litr;
        Turkiye trendyol = new Turkiye();
        Wakanda1 wakanda = new Wakanda1();
        Burundi1 burundi = new Burundi1();
        
        public Form1()
        {
            InitializeComponent();

        }
        public class Turkiye
        {
             
            

            public  int kgHesabla(int kilogram, int trKgDeyer)
            {
                
               int qiymet = trKgDeyer * kilogram;
                return qiymet;
            }
            public int litrHesabla(int litr, int trLitrDeyer)
            {
                int qiymet = trLitrDeyer * litr;
                return qiymet;
            }


        }

        public class Wakanda1
        {



            public int kgHesabla(int kilogram, int waKgDeyer)
            {

                int qiymet = waKgDeyer * kilogram;
                return qiymet;
            }
            public int litrHesabla(int litr, int waLitrDeyer)
            {
                int qiymet = waLitrDeyer * litr;
                return qiymet;
            }


        }
        public class Burundi1
        {



            public int kgHesabla(int kilogram, int buKgDeyer)
            {
                
                int qiymet = buKgDeyer * kilogram;
                return qiymet;
            }
            public int litrHesabla(int litr, int buLitrDeyer)
            {
                int qiymet = buLitrDeyer * litr;
                return qiymet;
            }


        }

        
      private void calculate_Click(object sender, EventArgs e)
        {

                try
                {


                    kilogram = int.Parse(textBox1.Text);
                    litr = int.Parse(textBox1.Text);
                    if (Burundi.Checked)
                    {
                        if (maye.Checked)
                        {
                            qiymet = burundi.litrHesabla(litr, buLitrDeyer);
                        }

                        else if (qati.Checked)
                        {
                            qiymet = burundi.kgHesabla(kilogram, buKgDeyer);
                        }

                    }
                    else if (Wakanda.Checked)
                    {
                        if (maye.Checked)
                        {
                            qiymet = wakanda.litrHesabla(litr, waLitrDeyer);
                        }

                        else if (qati.Checked)
                        {

                            qiymet = wakanda.kgHesabla(kilogram, waKgDeyer);
                        }

                    }
                    else if (Turkey.Checked)
                    {
                        if (maye.Checked)
                        {

                            qiymet = trendyol.litrHesabla(litr, trLitrDeyer);
                        }

                        else if (qati.Checked)
                        {

                            qiymet = trendyol.kgHesabla(kilogram, trKgDeyer);
                        }


                    }



                    if (textBox1.Text == "")
                    {
                        textBox2.Clear();
                    }

                }
                catch (Exception ex)
                {

                }
                textBox2.Text = qiymet.ToString();
           
            
        }


            private void Wakanda_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = global::cargoApp.Properties.Resources.ayr9s_1h3on;
        }

        private void Burundi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = global::cargoApp.Properties.Resources.depositphotos_367835064_stock_video_flag_burundi_seamless_infinity_loop;
        }

        private void Turkey_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = global::cargoApp.Properties.Resources.hd_turk_bayragi_2;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Sil_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
        }

        private void qati_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
   
}