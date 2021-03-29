using JosephCVWebsite.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephCVWebsite.Models
{
    public class SkillsEntry
    {
        [JsonProperty("skillName")]
        public string SkillName { get; set; }
        [JsonProperty("skillProficiency")]
        public string SkillProficiency { get; set; }
        [JsonProperty("skillType")]
        public SkillType SkillType { get; set; }

    }
}
