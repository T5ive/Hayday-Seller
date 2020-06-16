using Hayday_Seller.Utility;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hayday_Seller
{
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll")] private static extern bool GetAsyncKeyState(Keys value);

        private static readonly IntPtr Hayday = GetAppName.Hayday;
        private static int _num, _step;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            GetAppName.AppName();
            switch (TFive.Default.amount)
            {
                case 1:
                    radMinAmount.Checked = true;
                    break;

                case 2:
                    radMaxAmount.Checked = true;
                    break;
            }

            switch (TFive.Default.price)
            {
                case 1:
                    radMinAmount.Checked = true;
                    break;

                case 2:
                    radMidPrice.Checked = true;
                    break;

                case 3:
                    radMaxPrice.Checked = true;
                    break;
            }

            cbAutoSell.Checked = TFive.Default.autoSell;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TFive.Default.amount = radMinAmount.Checked ? 1 : 2;

            if (radMinAmount.Checked)
            {
                TFive.Default.price = 1;
            }
            else if (radMidPrice.Checked)
            {
                TFive.Default.price = 2;
            }
            else if (radMaxPrice.Checked)
            {
                TFive.Default.price = 3;
            }

            TFive.Default.autoSell = cbAutoSell.Checked;

            TFive.Default.Save();
        }

        private void tmHotkey_Tick(object sender, EventArgs e)
        {
            // Text = $@"Num:{_num} || Step:{_step}";
            if (GetAsyncKeyState(Keys.NumPad1))
            {
                _num = 1;
            }
            else if (GetAsyncKeyState(Keys.NumPad2))
            {
                _num = 2;
            }
            else if (GetAsyncKeyState(Keys.NumPad3))
            {
                _num = 3;
            }
            else if (GetAsyncKeyState(Keys.NumPad4))
            {
                _num = 4;
            }
            else if (GetAsyncKeyState(Keys.NumPad5))
            {
                _num = 5;
            }
            else if (GetAsyncKeyState(Keys.NumPad6))
            {
                _num = 6;
            }
            else if (GetAsyncKeyState(Keys.NumPad7))
            {
                _num = 7;
            }
            else if (GetAsyncKeyState(Keys.NumPad8))
            {
                _num = 8;
            }
            else if (GetAsyncKeyState(Keys.NumPad9))
            {
                _num = 9;
            }

            if (BotWorker.IsBusy != true)
            {
                if (!BotWorker.CancellationPending)
                {
                    BotWorker.RunWorkerAsync();
                }
            }
        }

        public struct Position
        {
            public int X;
            public int Y;

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private void BotWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_num == 0) return;

            _step = 1;

            if (_step != 1) return;
            var value = _num switch
            {
                1 => new Position(325, 280),
                2 => new Position(415, 280),
                3 => new Position(515, 280),
                4 => new Position(325, 350),
                5 => new Position(415, 350),
                6 => new Position(515, 350),
                7 => new Position(325, 420),
                8 => new Position(415, 420),
                9 => new Position(515, 420),
                _ => new Position()
            };
            Win32Bot.ClickInBg(Hayday, value.X, value.Y);
            Win32Bot.AwaitSleep(300);
            _step = 2;

            if (_step != 2) return;
            if (radMinAmount.Checked)
            {
                while (GetColor.GetColorFast(Hayday, 632, 298, 0xFFF8B0))
                {
                    Win32Bot.ClickInBg(Hayday, 632, 298);
                }
            }
            if (radMaxAmount.Checked)
            {
                while (GetColor.GetColorFast(Hayday, 791, 297, 0xFFF8B0))
                {
                    Win32Bot.ClickInBg(Hayday, 793, 300);
                }
            }

            Win32Bot.AwaitSleep(100);
            _step = 3;
            if (_step != 3) return;
            if (radMinPrice.Checked)
            {
                while (GetColor.GetColorFast(Hayday, 631, 387, 0xFFF8B0))
                {
                    Win32Bot.ClickInBg(Hayday, 677, 429);
                }
            }
            if (radMaxPrice.Checked)
            {
                while (GetColor.GetColorFast(Hayday, 789, 387, 0xFFF8B0))
                {
                    Win32Bot.ClickInBg(Hayday, 752, 429);
                }
            }

            Win32Bot.AwaitSleep(100);
            _step = 4;
            if (_step != 4) return;

            if (cbAutoSell.Checked)
            {
                Win32Bot.ClickInBg(Hayday, 707, 566);
            }

            _num = 0;
            _step = 0;
            BotWorker.CancelAsync();
        }
    }
}