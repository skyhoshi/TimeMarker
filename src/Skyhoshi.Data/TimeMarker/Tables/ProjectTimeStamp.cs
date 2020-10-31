using System;
using System.Collections.Generic;

namespace Skyhoshi.Data.TimeMarker.Tables
{
    public class ProjectTimeStamp
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTimeOffset? OffsetTimeStamp { get; set; }
        public List<ProjectTimeStampAudio> AudioRecordings { get; set; }

    }
}