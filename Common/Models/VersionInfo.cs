using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class VersionInfo
    {
        public long Version { get; set; }
        public Nullable<System.DateTime> AppliedOn { get; set; }
        public string Description { get; set; }
    }
}
