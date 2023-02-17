using Handler.ViewModels;
using InterfaceEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services;

namespace LoginReUniteofWorkApiIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryStoreproceController : ControllerBase
    {
        SQLservices sq = new SQLservices();

        [HttpPost]
        public IActionResult CreateCountry(RepoWithCountry repoWithCountry)
        {
            var res = sq.addCountry(repoWithCountry.CountryName);
            return Ok();
        }
        [HttpGet("getstatebycountry/{Country}")]
        public IActionResult getstatebycountry(int countryid)
        {
            var res = sq.getsatebycountry(countryid);
            var tb = res.Tables[0];
            List<RepoWithState> selectListItem = new List<RepoWithState>();
            foreach (var item in tb.Rows)
            {
                RepoWithState list = new RepoWithState();               
                list.StateId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                list.StateName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                selectListItem.Add(list);

            }
            return Ok(selectListItem);
        }
        [HttpGet]
        public IActionResult GetCountry()
        {
            var res = sq.GetAllcountry();
            var tb = res.Tables[0];
            List<RepoWithCountry> selectListItem = new List<RepoWithCountry>();
            foreach (var item in tb.Rows)
            {
                RepoWithCountry list = new RepoWithCountry();
                list.CountryId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                list.CountryName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                selectListItem.Add(list);

            }
            return Ok(selectListItem);

        }
        [HttpGet("GetState")]
        public IActionResult GetState()
        {
            var res = sq.GetAllState();
            var tb = res.Tables[0];
            List<RepoWithState> selectListItem = new List<RepoWithState>();
            foreach (var item in tb.Rows)
            {
                RepoWithState list = new RepoWithState();
                list.StateId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                list.StateName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                selectListItem.Add(list);

            }
            return Ok(selectListItem);

        }
        [HttpGet("GetCity")]
        public IActionResult GetCity()
        {
            var res = sq.GetAllCity();
            var tb = res.Tables[0];
            List<RepoWithCity> selectListItem = new List<RepoWithCity>();
            foreach (var item in tb.Rows)
            {
                RepoWithCity list = new RepoWithCity();
                list.CityId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                list.CityName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                selectListItem.Add(list);

            }
            return Ok(selectListItem);

        }
        [HttpGet("{stateid}")]
        public IActionResult GetCitybyState(int Cityid)
        {
            var res = sq.GetcitybyState(Cityid);
            var tb = res.Tables[0];
            List<RepoWithCity> selectListItem = new List<RepoWithCity>();
            foreach (var item in tb.Rows)
            {
                RepoWithCity list = new RepoWithCity();
                list.CityId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                list.CityName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                selectListItem.Add(list);

            }
            return Ok(selectListItem);
        }

    }
}
