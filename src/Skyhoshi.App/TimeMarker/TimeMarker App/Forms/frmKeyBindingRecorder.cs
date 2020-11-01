using Skyhoshi.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Skyhoshi.App.TimeMarker.Forms
{
    public partial class frmKeyBindingRecorder : Form
    {
        public bool RecordKeyPress { get; set; }
        public frmKeyBindingRecorder()
        {
            InitializeComponent();
            // register the event that is fired after the key press.
          Program.KeyBindingHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            
            Program.KeyBindingHook.RegisterHotKey(Windows.Forms.ModifierKeys.Control | Windows.Forms.ModifierKeys.Alt, Keys.F12);
        }

        private void btnSetKeyBinding_Click(object sender, EventArgs e)
        {
            RecordKeyPress = true;
        }

        #region Key Binding Events
        private void frmKeyBindingRecorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine($"Key Press: {e.KeyChar}");
        }

        private void frmKeyBindingRecorder_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Debug.WriteLine($@"Key Pressed: IsInputKey: {e.IsInputKey} Key: {e.KeyCode.ToString()} Modifier(s) Pressed: {(e.Alt | e.Control | e.Shift) == false}");
        }

        private void frmKeyBindingRecorder_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine($@"Key Pressed: Key: {e.KeyCode.ToString()} Modifier(s) Pressed: {(e.Alt | e.Control | e.Shift) == false}");
        }

        private void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Debug.WriteLine($@"Key Pressed: Key: {e.Key} Modifier(s) Pressed: {e.Modifier != 0000}");
            // show the keys pressed in a label.
            label1.Text = e.Modifier.ToString() + " + " + e.Key.ToString();
        }
        #endregion

        
        private void frmKeyBindingRecorder_Leave(object sender, EventArgs e)
        {
            RecordKeyPress = false;
        }

    }
}
