using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WinScroll
{
    public static class Macro
    {
        //Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        //Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int keyId);

        public static int WM_HOTKEY = 0x0312;
        #region fields
        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;

        #endregion
        public static void RegisterHotKey(Form f, Keys key, int id)
        {
            int modifiers = 0;

            if((key & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | MOD_ALT;

            if((key & Keys.Control) == Keys.Control)
                modifiers = modifiers | MOD_CONTROL;

            if((key & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | MOD_SHIFT;

            Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
            RegisterHotKey((IntPtr)f.Handle, id, (uint)modifiers, (uint)k);
        }

        public static void UnregisterHotKey(Form f, int id)
        {
            try
            {
                UnregisterHotKey(f.Handle, id); // modify this if you want more than one hotkey
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}