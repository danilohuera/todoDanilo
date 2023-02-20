using System;

namespace todoDanilo.Common.Models
{
    internal class todo
    {
        public DateTime CreateTime { get; set; }
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
