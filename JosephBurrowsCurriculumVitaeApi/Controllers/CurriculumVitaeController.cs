using JosephCVWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephBurrowsCurriculumVitaeApi.Controllers
{
    [ApiController]
    public class CurriculumVitaeController : ControllerBase
    {
        private readonly ILogger<CurriculumVitaeController> _logger;

        public CurriculumVitaeController(ILogger<CurriculumVitaeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("api/curriculumvitae")]
        public CurriculumVitae Get()
        {
            var json = System.IO.File.ReadAllText("./curriculumvitae.json");
            var cv = JsonConvert.DeserializeObject<CurriculumVitae>(json);
            return cv;
        }
    }
}
