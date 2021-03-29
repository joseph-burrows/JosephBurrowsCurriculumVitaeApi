using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephCVWebsite.Models
{
    public class EducationEntry
    {
        [JsonProperty("institutionName")]
        public string InstitutionName { get; set; }
        [JsonProperty("qualificationName")]
        public string QualificationName { get; set; }
        [JsonProperty("grade")]
        public string Grade { get; set; }
        [JsonProperty("startYear")]
        public int StartYear { get; set; }
        [JsonProperty("endYear")]
        public int EndYear { get; set; }

    }
}
