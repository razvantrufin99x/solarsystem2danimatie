using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using graphiccontrol;

namespace solarsystem2danimatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool animationisselected = false;

        float zoomx = 0.002918469f;
        float zoomy = 0.002918469f;
        float posx = 100.0f;
        float posy = 100.0f;
        public int currentx;
        public int currenty;
        public float dist;
        public int ismd = 0;
        public Font font1;
        public float distantaintredouapuncte2dxy(float x1, float y1, float x2, float y2)
        {
            float c;
            c = (float)Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2));
            return c;
        }
         
        public void draw()
        {
            userControl11.font0 = this.Font;
            try
            {
                userControl11.font0 = new Font("Aria", 6 + zoomx/10);
            }
            catch { }

            userControl11.g.Clear(Color.White);

            userControl11.g.DrawLine(new Pen(Color.Silver), -69 * zoomx + posx + 20, -69 * zoomy + posy + 20, 66600 * zoomx + posx + 20, 66600 * zoomy + posy + 20);

            userControl11.g.DrawEllipse(userControl11.pen0, (int)-69 * zoomx + posx, (int)-69 * zoomy + posy, 69 * zoomx, 69 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)5.791 * zoomx + posx, (int)5.791 * zoomy + posy, 1 + (int)0.2437 * zoomx, 1 + (int)0.2437 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)10.821 * zoomx + posx, (int)10.821 * zoomy + posy, 1 + (int)0.6052 * zoomx, 1 + (int)0.6052 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)14.96 * zoomx + posx, (int)14.96 * zoomy + posy, 1 + (int)0.6370 * zoomx, 1 + (int)0.6370 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)14.99 * zoomx + posx, (int)14.99 * zoomy + posy, 1 + (int)0.0300 * zoomx, 1 + (int)0.0500 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)22.79 * zoomx + posx, (int)22.79 * zoomy + posy, 1 + (int)0.3397 * zoomx, (int)0.3397 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)44.01 * zoomx + posx, (int)44.01 * zoomy + posy, 1 + (int)0.00975 * zoomx, 1 + (int)0.00975 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)77.84 * zoomx + posx, (int)77.84 * zoomy + posy, (int)7.1400 * zoomx, (int)7.1400 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)142.6 * zoomx + posx, (int)142.6 * zoomy + posy, (int)6.0400 * zoomx, (int)6.0400 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)287.1 * zoomx + posx, (int)287.1 * zoomy + posy, (int)2.5400 * zoomx, (int)2.5400 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)449.8 * zoomx + posx, (int)449.8 * zoomy + posy, (int)2.4500 * zoomx, (int)2.4500 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)589.4 * zoomx + posx, (int)589.4 * zoomy + posy, 1 + (int)0.0231 * zoomx, 1 + (int)0.0231 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)675 * zoomx + posx, (int)675 * zoomy + posy, 1 + (int)0.00712 * zoomx, 1 + (int)0.00712 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)645 * zoomx + posx, (int)645 * zoomy + posy, 1 + (int)0.00780 * zoomx, 1 + (int)0.00780 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)1000 * zoomx + posx, (int)1000 * zoomy + posy, 1 * zoomx, 1 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)1005 * zoomx + posx, (int)1005 * zoomy + posy, 1 + (int)0.001163 * zoomx, 1 + (int)0.001163 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)7260 * zoomx + posx, (int)7260 * zoomy + posy, 1 + (int)0.00445 * zoomx, 1 + (int)0.00445 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)30000 * zoomx + posx, (int)30000 * zoomy + posy, 1 * zoomx, 1 * zoomy);
            userControl11.g.DrawEllipse(userControl11.pen0, (int)66600 * zoomx + posx, (int)66600 * zoomy + posy, 1 * zoomx, 1 * zoomy);

            userControl11.g.DrawString("SOARELE SUN 0.0  690,000.00", userControl11.font0, userControl11.brush0, 1 * zoomx + 0 + posx, 1 * zoomy + posy);
            userControl11.g.DrawString("MERCUR 57.91 2437.00", userControl11.font0, userControl11.brush0, (int)5.791 * zoomx + 35 + posx, (int)5.791 * zoomy + posy);
            userControl11.g.DrawString("VENUS 108.21 6052.00", userControl11.font0, userControl11.brush0, (int)10.821 * zoomx + 45 + posx, (int)10.821 * zoomy + posy);
            userControl11.g.DrawString("PAMANTUL TERRA 149.60 6370.00", userControl11.font0, userControl11.brush0, (int)14.96 * zoomx + 55 + posx, (int)14.96 * zoomy + posy);
            userControl11.g.DrawString("LUNA 149.90 300.00", userControl11.font0, userControl11.brush0, (int)15.01 * zoomx + 65 + posx, (int)15.51 * zoomy + posy);
            userControl11.g.DrawString("MARTE 227.90 3397.00", userControl11.font0, userControl11.brush0, (int)22.79 * zoomx + 75 + posx, (int)22.79 * zoomy + posy);
            userControl11.g.DrawString("CERES / ASTEROIDS BELT 440.10 97.50", userControl11.font0, userControl11.brush0, (int)44.01 * zoomx + 35 + posx, (int)44.01 * zoomy + posy);
            userControl11.g.DrawString("JUPITER 778.40 71400.00", userControl11.font0, userControl11.brush0, (int)77.84 * zoomx + 35 + posx, (int)77.84 * zoomy + posy);
            userControl11.g.DrawString("SATURN 1426.00 60400.00", userControl11.font0, userControl11.brush0, (int)142.6 * zoomx + 35 + posx, (int)142.6 * zoomy + posy);
            userControl11.g.DrawString("URANUS 2871.00 24400.00", userControl11.font0, userControl11.brush0, (int)287.1 * zoomx + 35 + posx, (int)287.1 * zoomy + posy);
            userControl11.g.DrawString("NEPTUN 4498.00 24500.00", userControl11.font0, userControl11.brush0, (int)449.8 * zoomx + 35 + posx, (int)449.8 * zoomy + posy);
            userControl11.g.DrawString("PLUTO / TRANSNUPTIONAS OBJECT 5894.00 231.00", userControl11.font0, userControl11.brush0, (int)589.4 * zoomx + 35 + posx, (int)589.4 * zoomy + posy);
            userControl11.g.DrawString("MAKE MAKE  6750.00 75.00", userControl11.font0, userControl11.brush0, (int)675 * zoomx + 35 + posx, (int)675 * zoomy + posy);
            userControl11.g.DrawString("HAUMEA  6450.00 78.00", userControl11.font0, userControl11.brush0, (int)645 * zoomx + 35 + posx, (int)645 * zoomy + posy); 
            userControl11.g.DrawString("SCATTERED DISK ", userControl11.font0, userControl11.brush0, 1000 * zoomx + 35 + posx, 1000 * zoomy + posy);
            userControl11.g.DrawString("ERIS 1005 11.63 ", userControl11.font0, userControl11.brush0, 1005 * zoomx + 35 + posx, 1015 * zoomy + posy);
            userControl11.g.DrawString("SEDNA 7260 44.50 ", userControl11.font0, userControl11.brush0, 7260 * zoomx + 35 + posx, 7260 * zoomy + posy);
            userControl11.g.DrawString("ORTH CLOUD 2000 AU ", userControl11.font0, userControl11.brush0, 30000 * zoomx + 35 + posx, 30000 * zoomy + posy);
            userControl11.g.DrawString("ALPHA PROXIMA CENTAURY STAR 10 E 6 AU", userControl11.font0, userControl11.brush0, 66600 * zoomx + 35 + posx, 66600 * zoomy + posy);


            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 1 * zoomy + posy, 1 * zoomx + 0 + posx, 1 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)5.791 * zoomy + posy, (int)5.791 * zoomx + 35 + posx, (int)5.791 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)10.821 * zoomy + posy, (int)10.821 * zoomx + 45 + posx, (int)10.821 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)14.96 * zoomy + posy, (int)14.96 * zoomx + 55 + posx, (int)14.96 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)15.51 * zoomy + posy, (int)15.01 * zoomx + 65 + posx, (int)15.51 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)22.79 * zoomy + posy, (int)22.79 * zoomx + 75 + posx, (int)22.79 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)44.01 * zoomy + posy, (int)44.01 * zoomx + 35 + posx, (int)44.01 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)77.84 * zoomy + posy, (int)77.84 * zoomx + 35 + posx, (int)77.84 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)142.6 * zoomy + posy, (int)142.6 * zoomx + 35 + posx, (int)142.6 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)287.1 * zoomy + posy, (int)287.1 * zoomx + 35 + posx, (int)287.1 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)449.8 * zoomy + posy, (int)449.8 * zoomx + 35 + posx, (int)449.8 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)589.4 * zoomy + posy, (int)589.4 * zoomx + 35 + posx, (int)589.4 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)675 * zoomy + posy, (int)675 * zoomx + 35 + posx, (int)675 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, (int)645 * zoomy + posy, (int)645 * zoomx + 35 + posx, (int)645 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 1000 * zoomy + posy, 1000 * zoomx + 35 + posx, 1000 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 1015 * zoomy + posy, 1005 * zoomx + 35 + posx, 1015 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 7260 * zoomy + posy, 7260 * zoomx + 35 + posx, 7260 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 30000 * zoomy + posy, 30000 * zoomx + 35 + posx, 30000 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 66600 * zoomy + posy, 66600 * zoomx + 35 + posx, 66600 * zoomy + posy);
            userControl11.g.DrawLine(new Pen(Color.Red), -69 * zoomx + posx + 20, 1 * zoomy + posy, 1 * zoomx + 0 + posx, 1 * zoomy + posy);

        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            font1 = new Font("Aria", 6);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           // timer1.Stop();
            textBox1.Text = zoomx.ToString();
            textBox2.Text = zoomy.ToString();

            if (animationisselected == true)
            {
                zoomx += 0.005f;
                zoomy += 0.005f;
                draw();
            }
            else
            {
                draw();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zoomx-=0.05f;
            zoomy -= 0.05f;
            draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoomx += 0.05f;
            zoomy += 0.05f;
            draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            zoomx += 0.05f;
          
            draw();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            zoomy += 0.05f;
            draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zoomy -= 0.05f;
            
            draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zoomx -= 0.05f;
            
            draw();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zoomx=1.0f;

            draw();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zoomy=1.0f;

            draw();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zoomx = 1.0f;
            zoomy = 1.0f;
            draw();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            posy += 2 * zoomy; draw();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            posx += 2 * zoomx; draw();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            posx -= 2 * zoomx; draw();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            posy -= 2 * zoomy; draw();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            posx = 0.0f;
            posy = 0.0f;
        }

     

        private void button15_Click(object sender, EventArgs e)
        {
            posy += 10 * zoomy; draw();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            posx -= 10 * zoomx; draw();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            posy -= 10 * zoomy; draw();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            posx += 10 * zoomx; draw();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            zoomx += 2.0f;
            zoomy += 2.0f;
            draw();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            zoomx -= 2.0f;
            zoomy -= 2.0f;
            draw();
        }

        private void userControl11_MouseMove(object sender, MouseEventArgs e)
        {

            if (ismd == 1)
            {
                dist = distantaintredouapuncte2dxy(e.X, e.Y, currentx, currenty);
                if (currentx < e.X)
                {
                    zoomx += dist / 100000;
                    zoomy += dist / 100000;
                }
                else
                {
                    zoomx -= dist / 100000;
                    zoomy -= dist / 100000;
                }
                draw();
            }
            
        }

        private void userControl11_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;

        }

        private void userControl11_MouseDown(object sender, MouseEventArgs e)
        {
            currentx = e.X;
            currenty = e.Y;
            ismd = 1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 0.006841592f;
            draw();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 0.01620557f;
            draw();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 0.07788299f;
            draw();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 0.5669069f;
            draw();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 0.8703748f;
            draw();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 1.282183f;
            draw();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 1.951327f;
            draw();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 4.083335f;
            draw();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 6.083335f;
            draw();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 6.083335f;
            draw();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 12.19246f;
            draw();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            zoomx = zoomy = 26.19246f;
            draw();
        }

        /*
         ZOOMING LEVELS TO SEE
         * 
         * 0.006841592 	ALFA CENATAURY STAR
    0.01620557	ORTH CLOUD
    0.07788299	SEDNA
    0.5669069	ERRIS SCATTERED DISK
    0.8703748	MAKE MAKE
            HAUMEA
            PLUTO	
            TNO
    1.282183	NEPTUN
    1.951327	URANUS
    4.083335	SATURN
    6.083335	JUPITER
    12.19246	CERES
    26.19246	MARTE
            LUNA	
            PAMANTUL
            VENUS
            MERCUR
            SOARE

         * 
         */
    }
}
