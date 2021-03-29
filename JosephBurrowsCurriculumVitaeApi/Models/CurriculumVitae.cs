using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephCVWebsite.Models
{
    public class CurriculumVitae
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("linkedIn")]
        public string LinkedIn { get; set; }
        [JsonProperty("gitHub")]
        public string GitHub { get; set; }
        public List<EducationEntry> Education { get; set; }
        public List<WorkExperienceEntry> WorkExperience { get; set; }
        public List<SkillsEntry> Skills { get; set; }
        public List<AchievementsEntry> Achievements { get; set; }
    }
}
