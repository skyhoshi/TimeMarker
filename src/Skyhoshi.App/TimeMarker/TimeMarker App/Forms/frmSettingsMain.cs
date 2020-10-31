using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Skyhoshi.Windows.Forms;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Configuration.Default;

namespace Skyhoshi.App.TimeMarker
{
    public partial class frmSettingsMain : Skyhoshi.Windows.Forms.frmNotifyTray
    {
        private ISkyhoshiApplicationConfiguration AppConfiguration { get; set; }

        public frmSettingsMain() : base()
        {
            InitializeComponent();


            ToolStripMenuItem showMenuItem = frmNotifyTray.GetShowToolStripMenuItem();
            showMenuItem.Click += (sender, args) => { this.Activate(); };
            this.SystemNotifyIconPrimary.ContextMenuStrip.Items.Add(showMenuItem);
        }
        
        private void frmSettingsMain_Load(object sender, EventArgs e)
        {
            ISkyhoshiApplicationConfiguration config = Configuration.CommonConfiguration<SkyhoshiApplicationConfiguration>.LoadFromConfiguration();
            config.ValidateConfigurationIsLoaded();

            this.AudioSettingsPropertyGrid.SelectedObject = config;
        }

        private void AudioSettingsPropertyGrid_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            
        }

        private void AudioSettingsPropertyGrid_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }
    }
}
