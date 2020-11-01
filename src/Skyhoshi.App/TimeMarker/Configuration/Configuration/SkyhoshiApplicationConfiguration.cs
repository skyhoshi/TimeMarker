using System;
using System.Collections;
using System.Text;
using Skyhoshi.App.TimeMarker.Configuration.Audio;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Configuration.Default;

namespace Skyhoshi.App.TimeMarker.Configuration.Default
{
    public class SkyhoshiApplicationConfiguration : ApplicationConfiguration, ISkyhoshiApplicationConfiguration
    {
        public SkyhoshiApplicationConfiguration()
        {

        }
        
        public Recordings RecordingSettings { get; set; }

        public new bool ValidateConfigurationIsLoaded()
        {
            return base.ValidateConfigurationIsLoaded();
        }
    }
}
