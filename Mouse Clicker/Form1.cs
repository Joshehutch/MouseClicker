using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Mouse_Clicker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Tracker();

        }

        public List<int> points = new List<int>();
        public List<int> xCoords = new List<int>();
        public List<int> yCoords = new List<int>();
        public List<bool> Clk = new List<bool>();
        public List<bool> rghtClks = new List<bool>();
        public List<int> delay = new List<int>();



        private void pointList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            if (pointList.Items.Count > 0)
            {

                int ind = pointList.SelectedIndex;
                if (ind < 0)
                    ind = 0;
                xCoordLbl.Text = xCoords[ind].ToString();
                yCoordLbl.Text = yCoords[ind].ToString();
                ClickLbl.Text = (Clk[ind]) ? "Yes" : "No";
                rghtClickLbl.Text = (rghtClks[ind]) ? "Yes" : "No";
                delayLbl.Text = delay[ind].ToString();
            }
            else if(pointList.Items.Count < 1)
            {
                Start.Enabled = false;
                Clear.Enabled = false;
            }
        }

        async Task PutTaskDelay(int time)
        {
            await Task.Delay(time);
        }

        private async void Tracker()
        {
            while (true)
            {
                await PutTaskDelay(75); //75
                System.Drawing.Point derp = Cursor.Position;
                CursorList.Text = "Cursor Coordinates: " + derp.X.ToString() + ", " + derp.Y.ToString();

                if (Convert.ToBoolean(GetAsyncKeyState(Keys.Insert)))
                {
                    PointX.Text = derp.X.ToString();
                    PointY.Text = derp.Y.ToString();
                }

                if (Convert.ToBoolean(GetAsyncKeyState(Keys.Home)))
                {
                    PointSetter();
                    await PutTaskDelay(300); //300
                }

                if (Convert.ToBoolean(GetAsyncKeyState(Keys.Delete)))
                {
                    looping = false;
                    isRunning = false;
                }
                if (Convert.ToBoolean(GetAsyncKeyState(Keys.End)) && Start.Enabled)
                {
                    Starter();
                }
            }
        }

        private bool looping = false;
        private bool isRunning = false;

        private void Set_Click(object sender, EventArgs e)
        {
            PointSetter();
        }

        private void PointSetter()
        {
            points.Add((points.Any()) ? points.Last() + 1 : 1);
            xCoords.Add(Convert.ToInt32(PointX.Text));
            yCoords.Add(Convert.ToInt32(PointY.Text));
            Clk.Add(Convert.ToBoolean(ClickEnabled.CheckState));
            rghtClks.Add(Convert.ToBoolean(rghtClick.CheckState));
            delay.Add(Convert.ToInt32(Delay.Text));

            pointList.Items.Add("Point " + points.Last().ToString());

            if (pointList.Items.Count > 0)
            {
                Clear.Enabled = true;
                Start.Enabled = true;
            }

            pointList.SelectedIndex = pointList.Items.Count - 1;

        }

        private void Waiter(int millisecs)
        {
            System.Threading.Thread.Sleep(millisecs);
        }


        private void Start_Click(object sender, EventArgs e)
        {
            Starter();
        }

        private void Starter()
        {
            if (!isRunning)
            {
                isRunning = true;
                looping = Convert.ToBoolean(LoopCheck.CheckState);
                Looper();
            }
        }

        private bool started = false;
        private Point originalPos;

        private async void Looper()
        {
            originalPos = Cursor.Position;

            int counter = 0;
            while (counter < 1)
            {
                foreach (int pt in points)
                {
                    if (!isRunning)
                        return;
                    int ind = points.FindIndex(a => a == pt);
                    await PutTaskDelay(delay[ind]);
                    if(rghtClks[ind])
                        RightClick(xCoords[ind], yCoords[ind]);
                    else
                        LeftClick(Clk[ind], xCoords[ind], yCoords[ind]);
                }
                if (!looping)
                {
                    counter += 1;
                }
            }
            isRunning = false;
            Cursor.Position = originalPos;
        }

        private void Point1X_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (!Int32.TryParse(PointX.Text, out num))
            {
                System.Media.SystemSounds.Beep.Play();
                PointX.Text = "0";
            }
        }


        private void Point1Y_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (!Int32.TryParse(PointY.Text, out num))
            {
                Ding();
                PointY.Text = "0";
            }
        }

        private void Delay_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (!Int32.TryParse(Delay.Text, out num))
            {
                Ding();
                Delay.Text = "30";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int ind = pointList.SelectedIndex;

            if (ind == pointList.Items.Count - 1)
            {
                pointList.SelectedIndex = ind - 1;
            }
            else
            {
                pointList.SelectedIndex = ind + 1;
            }


            points.RemoveAt(ind);
            xCoords.RemoveAt(ind);
            yCoords.RemoveAt(ind);
            Clk.RemoveAt(ind);
            rghtClks.RemoveAt(ind);
            delay.RemoveAt(ind);
            pointList.Items.RemoveAt(ind);

            if (pointList.Items.Count < 1)
            {
                Delete.Enabled = false;
                Clear.Enabled = false;
                Start.Enabled = false;
            }
 
            xCoordLbl.Text = "None";
            yCoordLbl.Text = "None";
            ClickLbl.Text = "No";
            rghtClickLbl.Text = "No";
            delayLbl.Text = "None";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            pointList.Items.Clear();
            points.Clear();
            xCoords.Clear();
            yCoords.Clear();
            Clk.Clear();
            rghtClks.Clear();
            delay.Clear();

            Start.Enabled = false;
            Clear.Enabled = false;
            Delete.Enabled = false;

            xCoordLbl.Text = "None";
            yCoordLbl.Text = "None";
            ClickLbl.Text = "No";
            rghtClickLbl.Text = "No";
            delayLbl.Text = "None";
        }

        public void LeftClick(bool clk, int x, int y)
        {
            SetCursorPos(x, y);
            if (clk)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
        }

        public void RightClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
        }

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        private void LoopCheck_CheckedChanged(object sender, EventArgs e)
        {
            looping = Convert.ToBoolean(LoopCheck.CheckState);
        }

        public void Ding()
        {
            System.Media.SystemSounds.Beep.Play();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Close();
        }
    }
}
