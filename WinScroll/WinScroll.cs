using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WinScroll
{
    public partial class WinScroll : Form
    {
        private Timer timer;
        private Rectangle captureRectangle;
        private Point p = new Point();

        private const string aboutURL = "http://www.github.com/Petethegoat";
        private const string registry = "SOFTWARE\\WinScroll";
        private int fullLeft;
        private int upperRight;
        private int lowerRight;
        private int fullRight;

        public WinScroll()
        {
            fullLeft = "full_left".GetHashCode();
            upperRight = "upper_right".GetHashCode();
            lowerRight = "lower_right".GetHashCode();
            fullRight = "full_right".GetHashCode();

            InitializeComponent();
            Init();

            SizeChanged += new System.EventHandler(formResize);
            notifyIcon.DoubleClick += new System.EventHandler(windowShow);
            optionsToolStripMenuItem.Click += new System.EventHandler(windowShow);
            exitToolStripMenuItem.Click += new System.EventHandler(trayExit);

            captureX.LostFocus += new System.EventHandler(CaptureBounds);
            captureY.LostFocus += new System.EventHandler(CaptureBounds);
            captureWidth.LostFocus += new System.EventHandler(CaptureBounds);
            captureHeight.LostFocus += new System.EventHandler(CaptureBounds);

            captureCheck.CheckedChanged += new System.EventHandler(captureCheckChanged);
            trayCheck.CheckedChanged += new System.EventHandler(trayCheckChanged);
            startupCheck.CheckedChanged += new System.EventHandler(startupCheckChanged);
            windowCheck.CheckedChanged += new System.EventHandler(windowCheckChanged);

            aboutLink.Click += new System.EventHandler(aboutLinkClicked);
        }

        public void Init()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = 10;

            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureWidth.Value, (int)captureHeight.Value);

            //Startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
            if(rk != null && rk.GetValue("WinScroll") != null)
            {
                startupCheck.Checked = true;
                WindowState = FormWindowState.Minimized;
                
            }
            //Loading
            rk = Registry.CurrentUser.CreateSubKey(registry);
            rk = Registry.CurrentUser.OpenSubKey(registry, false);
            if(rk != null)
            {
                object o = rk.GetValue("HideTrayIcon");
                if(o != null && o.ToString() == "true")
                {
                    trayCheck.Checked = true;
                    notifyIcon.Visible = !trayCheck.Checked;
                }
                o = rk.GetValue("WindowSnapping");
                if(o != null && o.ToString() == "true")
                {
                    windowCheck.Checked = true;
                    RegisterHotkeys();
                }
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            NativeMethods.GetCursorPos  (out p);
            labelCoords.Text = p.X.ToString() + ", " + p.Y.ToString();
            UpdateCapture(captureCheck.Checked);
        }

        private void UpdateCapture(bool capture)
        {    
            if(capture)
            {
                NativeMethods.ClipCursor(ref captureRectangle);
            }
            else
            {
                NativeMethods.ClipCursor(IntPtr.Zero);
            }
        }

        private void CaptureBounds(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(((Control)captureX).Text))
                ((Control)captureX).Text = captureX.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureY).Text))
                ((Control)captureY).Text = captureY.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureWidth).Text))
                ((Control)captureWidth).Text = captureWidth.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureHeight).Text))
                ((Control)captureHeight).Text = captureHeight.Value.ToString();

            if(captureX.Value >= captureWidth.Value)
            {
                captureWidth.Value = captureX.Value + 1;
            }
            if(captureY.Value >= captureHeight.Value)
            {
                captureHeight.Value = captureY.Value + 1;
            }
            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureWidth.Value, (int)captureHeight.Value);
        }

        private void captureCheckChanged(object sender, EventArgs e)
        {
            UpdateCapture(captureCheck.Checked);
            if(captureCheck.Checked)
                timer.Start();
            else
                timer.Stop();
        }

        private void trayCheckChanged(object sender, EventArgs e)
        {
            notifyIcon.Visible = !trayCheck.Checked;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(registry, true);
            if(rk != null)
            {
                rk.SetValue("HideTrayIcon", trayCheck.Checked ? "true" : "false");
            }
        }

        private void startupCheckChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if(startupCheck.Checked)
                rk.SetValue("WinScroll", Application.ExecutablePath.ToString());
            else
                rk.DeleteValue("WinScroll", false);
        }

        private void windowShow(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

        private void trayExit(object sender, EventArgs e)
        {
            Close();
        }

        private void formResize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void aboutLinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(aboutURL);
        }


        private void windowCheckChanged(object sender, EventArgs e)
        {
            RegisterHotkeys();

            RegistryKey rk = Registry.CurrentUser.OpenSubKey(registry, true);
            if(rk != null)
            {
                rk.SetValue("WindowSnapping", windowCheck.Checked ? "true" : "false");
            }
        }

        private void RegisterHotkeys()
        {
            if(windowCheck.Checked)
            {
                Keys k = Keys.Control | Keys.Alt | Keys.Left;
                Macro.RegisterHotKey(this, k, fullLeft);

                k = Keys.Control | Keys.Alt | Keys.Up;
                Macro.RegisterHotKey(this, k, upperRight);

                k = Keys.Control | Keys.Alt | Keys.Down;
                Macro.RegisterHotKey(this, k, lowerRight);

                k = Keys.Control | Keys.Alt | Keys.Right;
                Macro.RegisterHotKey(this, k, fullRight);
            }
            else
            {
                Macro.UnregisterHotKey(this, fullLeft);
                Macro.UnregisterHotKey(this, upperRight);
                Macro.UnregisterHotKey(this, lowerRight);
                Macro.UnregisterHotKey(this, fullRight);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == Macro.WM_HOTKEY)
            {
                int col;
                int row;
                int w = 640;
                int h = 480;
                int x = 0;
                int y = 0;
                IntPtr window = NativeMethods.GetForegroundWindow();
                Point p;
                NativeMethods.GetCursorPos(out p);
                Screen activeScreen = Screen.FromPoint(p);

                if((int)m.WParam == fullLeft)
                {
                    col = (activeScreen.WorkingArea.Width / (int)columns.Value);
                    row = (activeScreen.WorkingArea.Height / (int)rows.Value);
                    w = col * (int)colsNum.Value;
                    h = row * (int)rows.Value;
                    x = activeScreen.Bounds.Left;   
                    y = 0;
                }
                else if((int)m.WParam == upperRight)
                {
                    col = (activeScreen.WorkingArea.Width / (int)columns.Value);
                    row = (activeScreen.WorkingArea.Height / (int)rows.Value);
                    w = col * 3;
                    h = row * 5;
                    x = activeScreen.Bounds.Left + col * 9;
                    y = 0;
                }
                else if((int)m.WParam == lowerRight)
                {
                    col = (activeScreen.WorkingArea.Width / (int)columns.Value);
                    row = (activeScreen.WorkingArea.Height / (int)rows.Value);
                    w = col * 3;
                    h = row * 3;
                    x = activeScreen.Bounds.Left + col * 9;
                    y = row * 5;
                }
                else if((int)m.WParam == fullRight)
                {
                    col = (activeScreen.WorkingArea.Width / (int)columns.Value);
                    row = (activeScreen.WorkingArea.Height / (int)rows.Value);
                    w = col * 3;
                    h = row * 8;
                    x = activeScreen.Bounds.Left + col * 9;
                    y = 0;
                }
                NativeMethods.MoveWindow(window, x, y, w, h, true);
            }
            else if(m.Msg == NativeMethods.WM_SHOWME)
            {
                Show();
                WindowState = FormWindowState.Normal;
                BringToFront();
                TopMost = true;
            }
            base.WndProc(ref m);
        }
    }
}
