using DataAccessLayer.DataContext;
using Handler.ViewModels;
using InterfaceEntity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;
using Services.Interfaces;

namespace LoginReUniteofWorkApiIdentity.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly DataAccessLayerContext _data;
        SQLservices sq = new SQLservices();

        public readonly ITaskpersonService _personService;
        public PersonController(ITaskpersonService productService)
        {
            _personService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> GetPersonList()
        {
            List<TaskPerson> personDetailsList = (List<TaskPerson>)await _personService.GetAllpersons();
            var res = sq.GetAllcountry();
            var tb = res.Tables[0];
            List<RepoWithCountry> listcountry = new List<RepoWithCountry>();
            foreach (var item in tb.Rows)
            {
                RepoWithCountry objcountry = new RepoWithCountry();
                objcountry.CountryId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                objcountry.CountryName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                listcountry.Add(objcountry);

            }
            var ress = sq.GetAllState();
            var tbb = ress.Tables[0];
            List<RepoWithState> liststate = new List<RepoWithState>();
            foreach (var item in tbb.Rows)
            {
                RepoWithState objstate = new RepoWithState();
                objstate.StateId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                objstate.StateName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                liststate.Add(objstate);

            }
            var resss = sq.GetAllCity();
            var tbbb = resss.Tables[0];
            List<RepoWithCity> listcity = new List<RepoWithCity>();
            foreach (var item in tbbb.Rows)
            {
                RepoWithCity objcity = new RepoWithCity();
                objcity.CityId = Convert.ToInt32(((System.Data.DataRow)item).ItemArray[0].ToString());
                objcity.CityName = ((System.Data.DataRow)item).ItemArray[1].ToString();
                listcity.Add(objcity);

            }
            var datalist = (from c in personDetailsList
                            select new personvm
                            {
                                CityName = listcity.Where(x => x.CityId == c.CityId).Select(x => x.CityName).FirstOrDefault(),
                                CountryName = listcountry.Where(x => x.CountryId == c.CountryId).Select(x => x.CountryName).FirstOrDefault(),
                                SatateName = liststate.Where(x => x.StateId == c.StateId).Select(x => x.StateName).FirstOrDefault(),
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                Email = c.Email,
                                Address = c.Address,
                                base64data = c.base64data,
                                PersonId= c.PersonId
                            }).ToList();
            if (personDetailsList == null)
            {
                return NotFound();
            }
            return Ok(datalist);
        }

        [HttpGet("{productId}")]
        // [HttpGet]
        public async Task<IActionResult> GetPersonById(int personid)
        {
            var persontDetails = await _personService.GetPersonById(personid);


            if (persontDetails != null)
            {
                return Ok(persontDetails);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreatePerson(CreatePerson personDetails)
        {
            TaskPerson obj = new TaskPerson();
            obj.FirstName = personDetails.FirstName;
            obj.Address = personDetails.Address;
            obj.LastName = personDetails.LastName;
            obj.Email = personDetails.Email;
            obj.StateId = personDetails.StateId;
            obj.CityId = personDetails.CityId;
            obj.CountryId= personDetails.CountryId;
            obj.base64data= personDetails.base64data;
            obj.FileName= personDetails.FileName;

            var ispersonCreated = await _personService.CreatePerson(obj);

            if (ispersonCreated)
            {
                return Ok(ispersonCreated);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdatePerson(CreatePerson personDetails)
        {
            TaskPerson obj = new TaskPerson();
            obj.FirstName = personDetails.FirstName;
            obj.Address = personDetails.Address;
            obj.LastName = personDetails.LastName;
            obj.Email = personDetails.Email;
            obj.StateId = personDetails.StateId;
            obj.CityId = personDetails.CityId;
            obj.CountryId = personDetails.CountryId;
            obj.base64data = personDetails.base64data;
            obj.FileName = personDetails.FileName;
            obj.PersonId= personDetails.PersonId;

            if (personDetails != null)
            {
                var ispersonCreated = await _personService.UpdatePerson(obj);
                if (ispersonCreated)
                {
                    return Ok(personDetails);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }


        // [HttpDelete("{personId}")]
        [HttpDelete]

        public async Task<IActionResult> DeletePerson(int personid)
        {
            var ispersontCreated = await _personService.DeletePerson(personid);

            if (ispersontCreated)
            {
                return Ok(ispersontCreated);
            }
            else
            {
                return BadRequest();
            }
        }


    }

}

