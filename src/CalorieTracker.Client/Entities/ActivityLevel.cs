using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker.Client.Entities
{
    public class ActivityLevel
    {
        public Guid Id { get; set; }
        public string ActivityLevelName { get; set; } = null!;
        public float ActivityLevelRate { get; set; }
    }
}
