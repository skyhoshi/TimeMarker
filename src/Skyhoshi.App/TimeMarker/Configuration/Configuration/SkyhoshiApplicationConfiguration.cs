using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Common.Interfaces.Configuration.Common;

namespace Skyhoshi.Configuration.Default
{

    public class SkyhoshiApplicationCommonConfiguration : CommonConfiguration<SkyhoshiApplicationConfiguration> , ISkyhoshiApplicationConfiguration
    {
        public virtual string RootStorageLocation { get; set; }
        public virtual IDictionary<IApplicationConfiguration, string> AdditionalConfigurationsToLoad { get; set; }

        public bool ValidateConfigurationIsLoaded()
        {
            throw new NotImplementedException();
        }
    }

    public class SkyhoshiApplicationConfiguration : ApplicationConfiguration
    {
        public SkyhoshiApplicationConfiguration(){}
        
        public Recordings RecordingSettings { get; set; }

        public bool ValidateConfigurationIsLoaded()
        {
            return base.ValidateConfigurationIsLoaded();
        }
    }
    public class Recordings
    {
        public int RecordTimeInSeconds { get; set; }
        public string RootRecordingStorage { get; set; } = "";
    }

    public class KeyCombo
    {
        public string KeyName { get;set; }
        public string KeyValue { get; set; }
    }
}
