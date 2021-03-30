using Amazon.S3;
using Amazon.S3.Transfer;
using JosephCVWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JosephBurrowsCurriculumVitaeApi.Controllers
{
    [ApiController]
    public class CurriculumVitaeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<CurriculumVitaeController> _logger;

        private readonly string _s3AccessKey;
        private readonly string _s3SecretAccessKey;

        private static string _cachedJson;
        private static DateTime? _cachedTime;

        public CurriculumVitaeController(ILogger<CurriculumVitaeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            _s3AccessKey = _configuration.GetValue<string>("s3AccessKey");
            _s3SecretAccessKey = _configuration.GetValue<string>("s3SecretAccessKey");
        }

        [HttpGet]
        [Route("api/curriculumvitae")]
        public CurriculumVitae Get()
        {


            var fileName = "curriculumvitae.json";
            var filePath = Directory.GetCurrentDirectory() + "/curriculumvitae.json";

            var json = "";

            if(_cachedJson == null || _cachedTime == null || (DateTime.Now - _cachedTime).Value.TotalMinutes > 60){
                TransferUtility fileTransferUtility = new TransferUtility(new AmazonS3Client(_s3AccessKey, _s3SecretAccessKey, Amazon.RegionEndpoint.EUWest2));
                fileTransferUtility.Download(filePath, "josephburrows.dev", fileName);
                json = System.IO.File.ReadAllText("./curriculumvitae.json");
                _cachedJson = json;
                _cachedTime = DateTime.Now;
            }
            else
            {
                json = _cachedJson;
            }

            var cv = JsonConvert.DeserializeObject<CurriculumVitae>(json);
            return cv;
        }
    }
}
