using InterfaceEntity.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interfaces;

namespace LoginReUniteofWorkApiIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        public readonly ICountryServics _countryservics;
        public CountryController(ICountryServics countryservics)
        {
            _countryservics = countryservics;
        }


        [HttpGet]
        public async Task<IActionResult> GetCountryList()
        {
            var countryList = await _countryservics.GetAllCountry();
            if (countryList == null)
            {
                return NotFound();
            }
            return Ok(countryList);
        }

    }
}
