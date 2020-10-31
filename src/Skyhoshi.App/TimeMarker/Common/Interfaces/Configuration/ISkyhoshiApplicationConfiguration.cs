using System;
using System.Collections.Generic;
using System.Text;
using Skyhoshi.Common.Interfaces.Configuration.Common;

namespace Skyhoshi.Common.Interfaces
{
    public interface ISkyhoshiApplicationConfiguration : IApplicationConfiguration
    {

        bool ValidateConfigurationIsLoaded();

    }
}
