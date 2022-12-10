using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Timers;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading;



namespace KoSharp
{
  
    public partial class Form1 : Form
    {
       
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            // NOTE: If you need error handling
            // bool success = GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }
        private static Color inttorgb(int rgbColor)
        {
            var byteAry = BitConverter.GetBytes(rgbColor);

            return Color.FromArgb(byteAry[3], byteAry[0], byteAry[1], byteAry[2]);


        }

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        AutoItX3 au3 = new AutoItX3();
        static string handle = "";

        
        public Form1()
        {
            au3.AutoItSetOption("SendKeyDelay", 25);
            au3.AutoItSetOption("SendKeyDownDelay", 25);
            InitializeComponent();
            

        }
      


        private void button1_Click(object sender, EventArgs e)
        {
            handle = au3.WinGetHandle(textBox1.Text);
            MessageBox.Show(handle);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled= false;
            button5.Enabled = true;
            au3.WinActivate(textBox1.Text);
            au3.Sleep(1000);
            timer1.Interval = trackBar1.Value;
            button2.Text = "Atak Basladi";
            button5.Text = "Atak Durdur";
            if (OtoAtak.Checked==true)
            {
                timer1.Enabled = true;
            }
            if (OtoWolf.Checked == true)
            {
                timer2.Enabled = true;
            }
            if (OtoDef.Checked == true)
            {
                timer3.Enabled = true;
            }
            if (OtoHp.Checked == true)
            {
                timer4.Enabled = true;
            }
            if (OtoMp.Checked == true)
            {
                timer5.Enabled = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            au3.Send(textBox2.Text,0);

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
            Point cursorhp;


            while (true)
            {
                int flag =0;
                if ((GetAsyncKeyState(Keys.K) & 0x8000) != 0)
                {
                    cursorhp = GetCursorPosition();

                    HpKoordX.Text = cursorhp.X.ToString();
                    HpKoordY.Text = cursorhp.Y.ToString();
                    flag ++;

                    if (flag!=0)
                    {
                        MessageBox.Show("Hp Koordinat alındı.");
                        break;
                    }

                }
                
            }


                       
            
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Point cursormp;


            while (true)
            {
                int flag = 0;
                if ((GetAsyncKeyState(Keys.K) & 0x8000) != 0)
                {
                    cursormp = GetCursorPosition();

                    MpKoordX.Text = cursormp.X.ToString();
                    MpKoordY.Text = cursormp.Y.ToString();
                    flag++;

                    if (flag != 0)
                    {
                        MessageBox.Show("Mp Koordinat alındı.");
                        break;
                    }

                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (OtoAtak.Checked==true)
            {
                timer1.Enabled = false;
                au3.Send(textBox5.Text, 0);
                au3.Sleep(1000);
                au3.Send(textBox5.Text, 0);
                timer1.Enabled = true;
            }
            else
            {
                au3.Send(textBox5.Text, 0);
                au3.Sleep(1000);
                au3.Send(textBox5.Text, 0);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            au3.Send(textBox6.Text, 0);
            au3.Sleep(500);
            au3.Send(textBox6.Text, 0);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int hpcolor = 0xB90000;
            hpcolor =au3.PixelGetColor(Convert.ToInt32(HpKoordX.Text), Convert.ToInt32(HpKoordY.Text));
            Color hp = inttorgb(hpcolor);
            
            if (hp.B <40)
            {
                au3.Send(textBox3.Text);
            }
            

          

        }

       

        private void timer5_Tick(object sender, EventArgs e)
        {
            int mpcolor = 0x1B2BD3;
            mpcolor = au3.PixelGetColor(Convert.ToInt32(MpKoordX.Text), Convert.ToInt32(MpKoordY.Text));
            Color mp = inttorgb(mpcolor);
            
            if (mp.R < 40)
            {
                au3.Send(textBox4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button5.Enabled = false;
            button2.Text = "Atak Baslat";
            button5.Text = "Atak Durduruldu";

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }
    }
}
