using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Skyhoshi.App.TimeMarker.Configuration.Default;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Common.Interfaces.Configuration;
using Skyhoshi.Configuration.Common;
using Skyhoshi.Configuration.Storage.Schemas.Json;

namespace Skyhoshi.Configuration.Default
{
    /// <summary>
    /// This class loads and binds the <see cref="SkyhoshiApplicationConfiguration"/> to and from files listed in the root location including Additional Configurations to load
    /// </summary>
    public class SkyhoshiApplicationConfigurationBuilderBuilder : CommonConfigurationBuilder<SkyhoshiApplicationConfiguration>, ISkyhoshiApplicationConfiguration
    {
        public SkyhoshiApplicationConfigurationBuilderBuilder()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage = new SkyhoshiApplicationJsonConfigurationFileStorage();
            this.AdditionalConfigurationsToLoad = new ConcurrentDictionary<IApplicationConfiguration, string>();
            this.RootStorageLocation = SkyhoshiApplicationJsonConfigurationFileStorage.FullPath;
        }

        public SkyhoshiApplicationConfigurationBuilderBuilder(string settingsPath) : this()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage.SetFullFilePath(settingsPath, Assembly.GetExecutingAssembly().FullName!);

        }

        [Browsable(false)] 
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SkyhoshiApplicationJsonConfigurationFileStorage SkyhoshiApplicationJsonConfigurationFileStorage { get; set; }

        public IConfigurationRoot Configuration { get; set; }
        private SkyhoshiApplicationConfiguration SkyhoshiApplicationConfiguration { get; set; }

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
            base.LoadFromDefaults();

            return CreateLoadSettingsFromDefaultLocations();
        }

        public SkyhoshiApplicationConfiguration CreateLoadSettingsFromDefaultLocations()
        {
            SkyhoshiApplicationConfigurationBuilderBuilder builderBuilder = new SkyhoshiApplicationConfigurationBuilderBuilder();
            Configuration = builderBuilder.Build();
            
            Configuration.Bind(SkyhoshiApplicationConfiguration);

            return SkyhoshiApplicationConfiguration;
        }
        
    }
}
