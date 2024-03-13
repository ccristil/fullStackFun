using FirstAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {

        private IFoodRepository _foodRepository;
        public MarriottFoodController (IFoodRepository temp)
        {
            _foodRepository = temp;
        }

        [HttpGet]
        public IEnumerable<MarriottFood> Get()
        {
            var foodData = _foodRepository.Foods.ToArray();

            return foodData;
        }
    }
}
