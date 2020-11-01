using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Skyhoshi.App.TimeMarker.Configuration.Default;
using Skyhoshi.App.TimeMarker.Forms;
using Skyhoshi.Configuration.Default;
using Skyhoshi.Windows.Forms;
using Svg;

namespace Skyhoshi.App.TimeMarker
{
    static class Program
    {
        public static SkyhoshiApplicationConfiguration TimeMarkerConfiguration { get; set; } = new SkyhoshiApplicationConfiguration();

        
        public static KeyboardHook KeyBindingHook { get; set; } = new KeyboardHook();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Microsoft.ApplicationInsights.TelemetryClient tc = new TelemetryClient(TelemetryConfiguration.CreateDefault());
            tc.InstrumentationKey = "0270dc4e-ba5a-48e2-9f1d-aac8a1b632c3";

            //TimeMarkerConfiguration = SkyhoshiApplicationConfigurationBuilderBuilder.CreateLoadSettingsFromDefaultLocations();

            TimeMarkerConfiguration.Load();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSettingsMain());
            //Application.Run(new frmSettingsMain());
            //Application.Run(new frmSettingsMain());
            //Application.Run(new frmSettingsMain());
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(frmSettingsMain))
            {
                Application.Exit();
            }
        }
    }
}
