using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        
        Random rastgele = new Random();
        int max = 52;
        int karta_vkolode = 0; //номер текущей карты в коллоде
        int[] ves_kart = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, };
        int[] name_kart = new int[53];
        int[] koloda = new int[53];
        int sat_user = 0;
        int andrey = 0;
        int pc = 0;
        String fullAppPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\card\\";


        int a1=0, a2=0, toplam1, xod1;
        private void button1_Click(object sender, EventArgs e)
        {
            xod1++;


            if (xod1 == 1)
            {
                if (label1.Text == "0" && (max - karta_vkolode) < 8) tasovka_kol();
                karta_vkolode += 2;
                a1 = rastgele.Next(1, max);
                a2 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (a1 == zn) pictureBox1.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                for (int zn = 1; zn <= max; zn++) if (a2 == zn) pictureBox2.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                toplam1 = ves_kart[a1] + ves_kart[a2];
            }

            label1.Text = ves_kart[a1].ToString();
            label2.Text = ves_kart[a2].ToString();



            if (xod1 == 2)
            {
                int a3;
                karta_vkolode++;
                a3 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (a3 == zn) pictureBox3.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                label3.Text = ves_kart[a3].ToString();
                toplam1 = toplam1 + ves_kart[a3];

            }

            if (xod1 == 3)
            {
                karta_vkolode++;
                int a4;
                a4 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (a4 == zn) pictureBox4.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                label4.Text = ves_kart[a4].ToString();
                toplam1 = toplam1 + ves_kart[a4];
            }
            label10.Text = toplam1.ToString();
            label23.Text = (max - karta_vkolode).ToString();
        }
         
 
            
            

        int b1=0, b2=0, toplam, xod;
        private void button2_Click(object sender, EventArgs e)
        {
            
            xod++;
            
            //if (b1 == 0 && b2 == 0)
            if (xod ==1)
            {
                if (label1.Text == "0" && (max-karta_vkolode) < 8) tasovka_kol();
                karta_vkolode += 2;
                b1 = rastgele.Next(1, max);
                b2 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (b1 == zn) pictureBox5.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                for (int zn = 1; zn <= max; zn++) if (b2 == zn) pictureBox6.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                toplam =  ves_kart[b1] +  ves_kart[b2];
            }

            label5.Text =  ves_kart[b1].ToString();
            label6.Text =  ves_kart[b2].ToString();
         

         //   if (toplam < 16)
            if (xod == 2)
            {   int b3;
            karta_vkolode++;
                b3 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (b3 == zn) pictureBox7.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg";
                label7.Text =  ves_kart[b3].ToString();
                toplam = toplam + ves_kart[b3];
               
            }
            //if (toplam < 16)
            if (xod == 3)
            {
                karta_vkolode++;
                int b4;
                b4 = rastgele.Next(1, max);
                for (int zn = 1; zn <= max; zn++) if (b4 == zn) pictureBox8.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn]) + ".jpg"; 
                label8.Text =  ves_kart[b4].ToString();
                toplam = toplam + ves_kart[b4];
            }
 label11.Text = toplam.ToString();
 label23.Text = (max - karta_vkolode).ToString();
         //   for (int zn = 1; zn <= max; zn++) if (label5.Text == zn.ToString())  pictureBox5.ImageLocation = @fullAppPath + Convert.ToString(name_kart[zn])+".jpg";
 
            
            
            
            }
       

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int andreytoplam, pctoplam;
            andreytoplam = Convert.ToInt32(label10.Text);
            pctoplam = Convert.ToInt32(label11.Text);

            if (andreytoplam > pctoplam && andreytoplam <= 21)
            {
                andrey = andrey + 10;
                label20.Text = andrey.ToString();
            }
            if (pctoplam > andreytoplam && pctoplam <= 21)
            {
                pc = pc + 10;
                label21.Text = andrey.ToString();
            }
            if (pctoplam > 21 && andreytoplam > 21)
            {
                MessageBox.Show("Перебор,ничья!!!");
            }
            if (pctoplam == andreytoplam && pctoplam <= 21 && andreytoplam <= 21)
            {
                pc = pc + 10;
                andrey = andrey + 10;
          }
            if (andrey == 50)
            {
                MessageBox.Show("Поздравляю с победой !!!");
            }
            if (pc == 50)
            {
                MessageBox.Show("К сожалению вы проиграли !!!");
            }
            if (pctoplam <= 21 && andreytoplam > 21)
            {
                pc = pc + 10;
                label21.Text = pc.ToString();
            }
            if (andreytoplam <= 21 && pctoplam > 21)
            {
                andrey = andrey + 10;
                label20.Text = andrey.ToString();}
            if (andreytoplam == 21)
            { MessageBox.Show("Очко !!!"); }
            if (pctoplam == 21)
            { MessageBox.Show("Очко !!!"); }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            sat_user = 0;
            xod = 0;
            xod1 = 0;
            b1 = 0; b2 = 0;
            a1 = 0; a2 = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label10.Text = "0"; 
            label11.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;
            /*pictureBox1.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox2.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox3.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox4.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox5.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox6.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox7.ImageLocation = @fullAppPath + "0.jpg";
            pictureBox8.ImageLocation = @fullAppPath + "0.jpg";
             */

            Bitmap image1 = new Bitmap(@fullAppPath + "0.jpg");
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image = pictureBox6.Image = pictureBox7.Image = pictureBox8.Image = image1;
            //pictureBox5.Image = image1;
            //pictureBox5.Image = image1;


        }
       void PutThreadSleep()
{
    Thread.Sleep(50);
}

       private void label13_Click(object sender, EventArgs e)
       {

       }

       private void Form1_Load(object sender, EventArgs e)
       {

           for (int i = 0; i <= name_kart.Length; i++)
           {
               name_kart[i] = i;
               tasovka_kol();           
               
           }
       }

       private void button5_Click(object sender, EventArgs e)
       {
           tasovka_kol();           
       }
       private void tasovka_kol()
       {
           for (int i = 0; i < koloda.Length; i++)
               koloda[i] = rastgele.Next(1, max);
           karta_vkolode = 0;
           label23.Text = (max).ToString();

       }

       private void button6_Click(object sender, EventArgs e)
       {
           label20.Text = "0";
           label21.Text = "0";
       }



    }

}
