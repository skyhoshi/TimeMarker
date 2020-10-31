using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Skyhoshi.Data.TimeMarker.Tables;

namespace Skyhoshi.Data.TimeMarkerContext
{
    public class TimeMarkerDataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public virtual DbSet<TimeMarkerProject> TimeMarkerProjects { get; set; }
        public virtual DbSet<ProjectTimeStamp> ProjectTimeStamps { get; set; }
        public virtual DbSet<ProjectTimeStampAudio> ProjectTimeStampAudio { get; set; }
    }
}
