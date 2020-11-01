﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Skyhoshi.App.TimeMarker.Configuration.Default;
using Skyhoshi.App.TimeMarker.Forms;
using Skyhoshi.Windows.Forms;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Configuration.Default;

namespace Skyhoshi.App.TimeMarker
{
    public partial class frmSettingsMain : Skyhoshi.Windows.Forms.frmNotifyTray
    {
        private SkyhoshiApplicationConfiguration AppConfiguration { get; set; }

        public frmSettingsMain() : base()
        {
            InitializeComponent();


            ToolStripMenuItem showMenuItem = frmNotifyTray.GetShowToolStripMenuItem();
            showMenuItem.Click += (sender, args) => { this.Activate(); };
            this.SystemNotifyIconPrimary.ContextMenuStrip.Items.Add(showMenuItem);

            if (global::Skyhoshi.App.TimeMarker.Program.TimeMarkerConfiguration.ValidateConfigurationIsLoaded())
            {
               this.AppConfiguration = global::Skyhoshi.App.TimeMarker.Program.TimeMarkerConfiguration;
                this.AudioSettingsPropertyGrid.SelectedObject = AppConfiguration;
            }

            
        }
        
        private void frmSettingsMain_Load(object sender, EventArgs e)
        {

        }

        private void AudioSettingsPropertyGrid_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            
        }

        private void AudioSettingsPropertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }

        private void btnSetHotkey_Click(object sender, EventArgs e)
        {
            frmKeyBindingRecorder keyBindingRecorder = new frmKeyBindingRecorder();
            var result = keyBindingRecorder.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnTestHotkey_Click(sender, e);
            }
        }

        private void btnTestHotkey_Click(object sender, EventArgs e)
        {
            //Test the Keybinding by turning off the recording process and show when the keybinding has been pressed.
        }
    }
}
