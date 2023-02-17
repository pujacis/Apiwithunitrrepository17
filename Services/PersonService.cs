using DataAccessLayer.DataContext;
using Handler.ViewModels;
using InterfaceEntity.Interface;
using InterfaceEntity.Models;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonService : ITaskpersonService
    {
        public IUnitOfWork _unitOfWork;
      
        public PersonService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreatePerson(TaskPerson persondetails)
        {
            if (persondetails != null)
            {
                await _unitOfWork.taskperson.Add(persondetails);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }


        public async Task<bool> DeletePerson(int personid)
        {
            if (personid > 0)
            {
                var persondetails = await _unitOfWork.taskperson.GetById(personid);
                if (persondetails != null)
                {
                    _unitOfWork.taskperson.Delete(persondetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }


        public async Task<IEnumerable<TaskPerson>> GetAllpersons()
        {
         
            
        var persondetailsList = await _unitOfWork.taskperson.GetAll();
        
         
            return persondetailsList;
        }


        public async Task<TaskPerson> GetPersonById(int personid)
        {
            if (personid > 0)
            {
                var persondetails = await _unitOfWork.taskperson.GetById(personid);
                if (persondetails != null)
                {
                    return persondetails;
                }
            }
            return null;
        }


        public async Task<bool> UpdatePerson(TaskPerson persondetails)
        {
            if (persondetails != null)
            {
                var person = await _unitOfWork.taskperson.GetById(persondetails.PersonId);
                if (person != null)
                {
                    person.FirstName = persondetails.FirstName;
                    person.FirstName = persondetails.FirstName;
                    person.Email = persondetails.Email;
                    person.CountryId = persondetails.CountryId;
                    person.StateId = persondetails.StateId;
                    person.base64data = persondetails.base64data;
                   person.Address = persondetails.Address;
                    person.CityId = persondetails.CityId;
                    _unitOfWork.taskperson.Update(person);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

    }
}

