using System;
using System.Collections.Generic;

namespace Skyhoshi.Data.TimeMarker.Tables
{
    
    public class TimeMarkerProject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ProjectTimeStamp> TimeStamps { get; set; }
    }
}

