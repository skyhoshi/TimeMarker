using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Skyhoshi.App.TimeMarker.Configuration.Default;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Common.Interfaces.Configuration;
using Skyhoshi.Configuration.Common;
using Skyhoshi.Configuration.Common.Generic;
using Skyhoshi.Configuration.Storage.Schemas.Json;

namespace Skyhoshi.Configuration.Default
{

    //public class SkyhoshiConfig : ImplementationOfCommonConfigurationBuilderOf<SkyhoshiCommonApplicationConfiguration>
    //{

    //}

    /// <summary>
    /// This class loads and binds the <see cref="SkyhoshiCommonApplicationConfiguration"/> to and from files listed in the root location including Additional Configurations to load
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class SkyhoshiApplicationConfigurationBuilder : ImplementationOfCommonConfigurationBuilderOf<SkyhoshiCommonApplicationConfiguration>, IConfigurationBuilder
    {
        #region Properties 
        //[Browsable(false)] 
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //public new ICommonConfigurationBuilder<SkyhoshiCommonApplicationConfiguration> ConfigurationBuilder { get; private set; }
        //
        //[Browsable(false)] 
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //public ConfigurationBuilder SettingsFolderConfigurationBuilder { get; private set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public SkyhoshiApplicationJsonConfigurationFileStorage SkyhoshiApplicationJsonConfigurationFileStorage { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IConfiguration Configuration { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private SkyhoshiCommonApplicationConfiguration SkyhoshiCommonApplicationConfiguration { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string RootStorageLocation { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IDictionary<IApplicationConfiguration, string> AdditionalConfigurationsToLoad { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsBound { get; set; }
        #endregion

        #region Constructors

        public SkyhoshiApplicationConfigurationBuilder()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage = new SkyhoshiApplicationJsonConfigurationFileStorage();
            this.AdditionalConfigurationsToLoad = new ConcurrentDictionary<IApplicationConfiguration, string>();
            this.RootStorageLocation = SkyhoshiApplicationJsonConfigurationFileStorage.FullPath;
            this.ConfigurationBuilder = this;
        }

        public SkyhoshiApplicationConfigurationBuilder(SkyhoshiCommonApplicationConfiguration currentSkyhoshiCommonApplicationConfiguration) : this()
        {
            this.SkyhoshiCommonApplicationConfiguration = currentSkyhoshiCommonApplicationConfiguration;
        }

        public SkyhoshiApplicationConfigurationBuilder(string settingsPath) : this()
        {
            this.SkyhoshiApplicationJsonConfigurationFileStorage.SetFullFilePath(settingsPath, Assembly.GetExecutingAssembly().FullName!);
        }

        #endregion

        #region Methods

        #region Validate Methods

        public bool ValidateConfigurationIsLoaded()
        {
            if (IsBound)
            {
                return true;
            }

            return false;
        }
       
        #endregion

        #region Save Methods

        public new void Save()
        {
            this.Save(this.SkyhoshiCommonApplicationConfiguration);
        }
        public new void Save(SkyhoshiCommonApplicationConfiguration config)
        {
            string jsonString = GetConfigurationAsString(this.Configuration);
            try
            {
                Debugger.Break();
                this.WriteFileToDisk(jsonString, this.SkyhoshiApplicationJsonConfigurationFileStorage.FullPath);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }
        #endregion

        #region Load Methods

        public SkyhoshiCommonApplicationConfiguration CreateLoadSettingsFromDefaultLocations(SkyhoshiCommonApplicationConfiguration currentSkyhoshiCommonApplicationConfiguration = null)
        {
            this.ConfigurationBuilder = new SkyhoshiApplicationConfigurationBuilder(currentSkyhoshiCommonApplicationConfiguration);

            this.Build();

            Configuration.Bind(SkyhoshiCommonApplicationConfiguration);
            SkyhoshiCommonApplicationConfiguration.Builder = this;
            return SkyhoshiCommonApplicationConfiguration;
        }



       public new SkyhoshiCommonApplicationConfiguration Load()
       {
         return  base.LoadFromConfiguration();
           //return base.Load();
       }

        //public IApplicationConfiguration Load()
        //{
        //    return base.Load();
        //}

        public new SkyhoshiCommonApplicationConfiguration LoadFromDefaults()
        {
            var config = base.LoadFromDefaults();
            config = CreateLoadSettingsFromDefaultLocations(config);
            //config =  CreateLoadSettingsFromDefaultLocations();
            return config;
        }



        #endregion

        #region Build Methods

        public new IConfigurationRoot Build()
        {
            Configuration = ConfigurationBuilder.Build();
            return (IConfigurationRoot)Configuration;
        }

        #endregion

        #endregion
    }
}
