using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephCVWebsite.Models
{
    public class WorkExperienceEntry
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [JsonProperty("roleName")]
        public string RoleName { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("companyUrl")]
        public string CompanyUrl { get; set; }

    }
}
