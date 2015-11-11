using System;
using NAudio.Wave;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace AlphaBravoCharlie_encoder
{
    public partial class Form1 : Form
    {
        public int counter;
        private string text;
        private float vol;
        public string english = "abcdefghijklmnopqrstuvwxyz .0123456789";
        public Form1()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            vol = VolumeTrk.Value*float.Parse((0.01).ToString());
            text = MainRTextBox.Text;
            Stream str;
            SoundPlayer sp = new SoundPlayer();

            WaveFileReader wfr = new WaveFileReader(Properties.Resources.background);
            WaveChannel32 wc = new WaveChannel32(wfr,vol,0);
            DirectSoundOut wfo = new DirectSoundOut();
            wfo.Init(wc);
            wfo.Play();
            System.Timers.Timer glc = new System.Timers.Timer(Int32.Parse(IntervalBox.Text));
            if (IntervalBox.Enabled)
            {
                
                glc.Start();
                glc.Elapsed += new ElapsedEventHandler(glctick);
            }
            
            System.Timers.Timer la = new System.Timers.Timer(2000);
            la.Elapsed += new ElapsedEventHandler(latick);
            la.Start();
            foreach (char a in text.ToLower())
            {
               //Ищем совпадения по буквам и произносим символ
                if (english.IndexOf(a) != -1)
                {
                   switch (a)
                   {
                       case 'a':
                           
                            str = Properties.Resources.a;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(474 + Int32.Parse(TextSpeed.Text));
                            
                            break;
                       case 'b':

                            str = Properties.Resources.b;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(504 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'c':

                            str = Properties.Resources.c;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(517 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'd':

                            str = Properties.Resources.d;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(478 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'e':

                            str = Properties.Resources.e;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(388 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'f':

                            str = Properties.Resources.f;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(623 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'g':

                            str = Properties.Resources.g;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(359 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'h':

                            str = Properties.Resources.h;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(571 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'i':

                            str = Properties.Resources.i;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(432 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'j':

                            str = Properties.Resources.j;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(548 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'k':

                            str = Properties.Resources.k;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(457 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'l':

                            str = Properties.Resources.l;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(434 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'm':

                            str = Properties.Resources.m;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(511 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'n':

                            str = Properties.Resources.n;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(614 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'o':

                            str = Properties.Resources.o;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(460 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'p':

                            str = Properties.Resources.p;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(420 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'q':

                            str = Properties.Resources.q;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(500 + Int32.Parse(TextSpeed.Text));

                            break;

                       case 'r':

                            str = Properties.Resources.r;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(632 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 's':

                            str = Properties.Resources.s;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(704 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 't':

                            str = Properties.Resources.t;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(571 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'u':

                            str = Properties.Resources.u;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(707 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'v':

                            str = Properties.Resources.v;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(646 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'w':

                            str = Properties.Resources.w;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(580 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'x':

                            str = Properties.Resources.x;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(636 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'y':

                            str = Properties.Resources.y;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(666 + Int32.Parse(TextSpeed.Text));

                            break;
                       case 'z':

                            str = Properties.Resources.z;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(486 + Int32.Parse(TextSpeed.Text));
                            break;

                       case '0':

                            str = Properties.Resources.n0;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(503 + Int32.Parse(TextSpeed.Text));
                            break;

                       case '1':

                            str = Properties.Resources.n1;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(463 + Int32.Parse(TextSpeed.Text));
                            break;

                       case '2':

                            str = Properties.Resources.n2;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(418 + Int32.Parse(TextSpeed.Text));
                            break;

                       case '3':

                            str = Properties.Resources.n3;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(450 + Int32.Parse(TextSpeed.Text));
                            break;

                       case '4':

                            str = Properties.Resources.n4;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(507 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '5':

                            str = Properties.Resources.n5;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(582 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '6':

                            str = Properties.Resources.n6;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(582 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '7':

                            str = Properties.Resources.n7;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(520 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '8':

                            str = Properties.Resources.n8;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(373 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '9':

                            str = Properties.Resources.n9;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(523 + Int32.Parse(TextSpeed.Text));
                            break;
                       case '.':
                            str = Properties.Resources.dot;
                            sp = new SoundPlayer(str);
                            sp.Play();
                            Thread.Sleep(663 + Int32.Parse(TextSpeed.Text));
                            break;

                       case ' ':
                            Thread.Sleep(Math.Abs(Int32.Parse(TextSpeed.Text)));
                            break;
                            
                           
                   }
                
                   
                
                   
                }
                
            }
            try
            { glc.Stop();
            glc.Dispose();
            }
            catch{}
            la.Stop();
            la.Dispose();

            wfo.Dispose();
            wc.Dispose();
            wfr.Dispose();
            GC.Collect();
        }
        
        private void latick(object sender, ElapsedEventArgs e)
        {
            Looper();
        }
        //Сделали щелчки
        private void glctick(object sender, ElapsedEventArgs e)
        {
            WaveFileReader wfra = new WaveFileReader(Properties.Resources.glitch);

            WaveChannel32 wcs = new WaveChannel32(wfra, vol, 0);
            DirectSoundOut wfod = new DirectSoundOut();
            wfod.Init(wcs);
            wfod.Play();
        }
        //Организовали зацикливание помех
        private void Looper()
        {
            WaveFileReader wfr = new WaveFileReader(Properties.Resources.background);

            WaveChannel32 wc = new WaveChannel32(wfr, vol, 0);
            DirectSoundOut wfo = new DirectSoundOut();
            wfo.Init(wc);
            wfo.Play();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void glitchCB_CheckedChanged(object sender, EventArgs e)
        {
            if (glitchCB.Checked)
                IntervalBox.Enabled = true;
            else if (!glitchCB.Checked)
                IntervalBox.Enabled = false;
        }
    }
}
