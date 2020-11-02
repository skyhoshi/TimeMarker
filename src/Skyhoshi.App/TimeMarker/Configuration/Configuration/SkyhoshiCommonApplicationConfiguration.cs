using System;
using System.Collections;
using System.Text;
using Microsoft.Extensions.Configuration;
using Skyhoshi.App.TimeMarker.Configuration.Audio;
using Skyhoshi.Common.Interfaces;
using Skyhoshi.Common.Interfaces.Configuration;
using Skyhoshi.Configuration.Common;
using Skyhoshi.Configuration.Common.Generic;
using Skyhoshi.Configuration.Default;

namespace Skyhoshi.App.TimeMarker.Configuration.Default
{
    public class SkyhoshiCommonApplicationConfiguration : CommonApplicationConfiguration, ISkyhoshiApplicationConfiguration
    {
        #region Properties

        public new IConfigurationBuilder Builder { get; set; }
        private CommonConfigurationBuilder<SkyhoshiCommonApplicationConfiguration> CommonConfigurationBuilder => (CommonConfigurationBuilder<SkyhoshiCommonApplicationConfiguration>) Builder;

        public bool BringAnyOpenWindowToFrontOnShortcutKeyPressed { get; set; } = false;
        
        public bool AllowAnyMessageBoxOnShortcutKeyPressed { get; set; } = false;

        public Recordings RecordingSettings { get; set; }

        #endregion
        
        public SkyhoshiCommonApplicationConfiguration()
        {
            Builder = new SkyhoshiApplicationConfigurationBuilder();
        }

        public SkyhoshiCommonApplicationConfiguration(SkyhoshiApplicationConfigurationBuilder builder)
        {
            this.Builder = builder;
        }

        public override void Save()
        {
            //CommonConfigurationBuilder.
            base.Save(this);
        }

        
    }
}
