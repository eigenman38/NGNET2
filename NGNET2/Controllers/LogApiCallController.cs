using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGNET2.DAO;

namespace NGNET2.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class LogApiCallController : ControllerBase
    {
        private readonly static List<LogApiData> tempStorage = new();

        [HttpPost]
        public LogApiData LogApiCall([FromBody] LogApiData logApiData)
        {

            LogApiCallController.tempStorage.Add(logApiData);

            return logApiData;

        }

        [HttpGet]
        public IEnumerable<LogApiData> GetAllApiCallLogs()
        {

            return LogApiCallController.tempStorage;
        }


    }
}
