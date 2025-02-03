using Microsoft.AspNetCore.Mvc;

namespace hng12_stage_0.Controllers
{
    public class InformationController : Controller
    {
        [HttpGet]
        public IActionResult GetInformation()
        {
            var response = new
            {
                email = "adeyemieyinjuoluwa@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/adebisi4145/hng12-stage-0"
            };

            return Ok(response);
        }
    }
}
