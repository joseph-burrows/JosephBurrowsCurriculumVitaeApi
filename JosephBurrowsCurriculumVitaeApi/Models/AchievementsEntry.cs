using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephCVWebsite.Models
{
    public class AchievementsEntry
    {
        [JsonProperty("achievementName")]
        public string AchievementName { get; set; }
        [JsonProperty("achievementDescription")]
        public string AchievementDescription { get; set; }
    }
}
