using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Skyhoshi.App.TimeMarker.Configuration.Default;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Common.Interfaces.Configuration;
using Skyhoshi.Common.Interfaces.Configuration.Common;
using Skyhoshi.Configuration.Common;
using Skyhoshi.Configuration.Storage.Schemas.Json;

namespace Skyhoshi.Configuration.Default
{
    /// <summary>
    /// This class loads and binds the <see cref="SkyhoshiApplicationConfiguration"/> to and from files listed in the root location including Additional Configurations to load
    /// </summary>
    public class SkyhoshiApplicationConfigurationBuilder : CommonConfiguration<SkyhoshiApplicationConfiguration>, ISkyhoshiApplicationConfiguration
    {
        public SkyhoshiApplicationConfigurationBuilder()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage = new SkyhoshiApplicationJsonConfigurationFileStorage();
            this.AdditionalConfigurationsToLoad = new ConcurrentDictionary<IApplicationConfiguration, string>();
            this.RootStorageLocation = SkyhoshiApplicationJsonConfigurationFileStorage.FullPath;
        }

        public SkyhoshiApplicationConfigurationBuilder(string settingsPath) : this()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage.SetFullFilePath(settingsPath, Assembly.GetExecutingAssembly().FullName!);

        }

        [Browsable(false)] 
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SkyhoshiApplicationJsonConfigurationFileStorage SkyhoshiApplicationJsonConfigurationFileStorage { get; set; }
        [Browsable(false)] 
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string RootStorageLocation { get; set; }
        [Browsable(false)] 
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IDictionary<IApplicationConfiguration, string> AdditionalConfigurationsToLoad { get; set; }
        [Browsable(false)] 
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsBound { get; set; }
        public bool ValidateConfigurationIsLoaded()
        {
            if (IsBound)
            {
                return true;
            }

            return false;
        }

        public override IApplicationConfiguration LoadFromDefaults()
        {
            return base.LoadFromDefaults();
        }

        public static SkyhoshiApplicationConfiguration CreateLoadSettingsFromDefaultLocations()
        {
            SkyhoshiApplicationConfiguration config = new SkyhoshiApplicationConfiguration();
            
            return config;

        }
    }
}
