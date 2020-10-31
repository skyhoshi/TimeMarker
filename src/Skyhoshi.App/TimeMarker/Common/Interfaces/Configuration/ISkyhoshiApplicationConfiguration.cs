using System;
using System.Collections.Generic;
using System.Text;
using Skyhoshi.Common.Interfaces.Configuration;

namespace Skyhoshi.Common.Interfaces
{
    public interface ISkyhoshiApplicationConfiguration : IApplicationConfiguration
    {

        bool ValidateConfigurationIsLoaded();

    }
}
