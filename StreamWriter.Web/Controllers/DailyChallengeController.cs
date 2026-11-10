using Microsoft.AspNetCore.Mvc;

namespace StreamWriter.Web.Controllers
{
    [Route("daily-challenge")]
    [ApiController]
    public class DailyChallengeController : ControllerBase
    {
        private readonly IDailyChallengeTextGenerator _dailyChallengeTextGenerator;

        public DailyChallengeController(IDailyChallengeTextGenerator dailyChallengeTextGenerator)
        {
            _dailyChallengeTextGenerator = dailyChallengeTextGenerator;
        }

        [HttpGet("text")]
        public async Task<string> GetDailyChallengeText()
        {
            string text = await _dailyChallengeTextGenerator.GetText();
            return text;
        }
    }
}
