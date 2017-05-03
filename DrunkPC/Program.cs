using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace DrunkPC
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("main");




            Thread tMouse = new Thread(Mouse);
            Thread tKeyboard = new Thread(KeyBoard);
            Thread tSound = new Thread(Sound);
            Thread tPopup = new Thread(Popup);

            Thread.Sleep(3000);

            tMouse.Start();
            tKeyboard.Start();
            tSound.Start();
            tPopup.Start();

            Thread.Sleep(45000);

            tMouse.Abort();
            tKeyboard.Abort();
            tSound.Abort();
            tPopup.Abort();

        }


#region ThreadMethods
        static void Mouse()
        {
            Thread.Sleep(2000);
            Console.WriteLine("mouse");
            while (true)
            {
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X - rnd.Next(-5, 5), Cursor.Position.Y - rnd.Next(-5, 5));


                Thread.Sleep(rnd.Next(500, 1000));
            }
        }

        static void KeyBoard()
        {
            Thread.Sleep(2000);
            Console.WriteLine("keyboard");
            while (true)
            {
                SendKeys.SendWait(((char)rnd.Next(97,122)).ToString());

                Thread.Sleep(rnd.Next(rnd.Next(800,1200)));
            }
        }

        static void Sound()
        {
            Thread.Sleep(2000);
            Console.WriteLine("sound");
            while (true)
            {
                if(rnd.Next(10)>8)
                    switch (rnd.Next(1,5))
                    {
                        case 1:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 2: SystemSounds.Beep.Play();
                            break;
                        case 3:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 4:
                            SystemSounds.Hand.Play();
                            break;
                        case 5:
                            SystemSounds.Question.Play();
                            break;
                        default:
                            break;
                    }

                Thread.Sleep(500);
            }
        }

        static void Popup()
        {
            Console.WriteLine("popup");
            Thread.Sleep(2000);
            while (true)
            {
                

                if(rnd.Next(0,100) >= 50)
                        MessageBox.Show("Enternet Explorer has stopped working", "Enternet Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      else 
                        MessageBox.Show("Your system is running low on resources", "Microsoft Windows", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        


                Thread.Sleep(rnd.Next(20000,30000));
            }
        }

        
        #endregion
    }



}
