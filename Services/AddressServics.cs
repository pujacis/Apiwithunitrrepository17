using InterfaceEntity.Interface;
using InterfaceEntity.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AddressServics : IAddressServics
    {
        public IUnitOfWork _unitOfWork;

        public AddressServics(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreateAddress(Address addressdeatils)
        {
            if (addressdeatils != null)
            {
                await _unitOfWork.address.Add(addressdeatils);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteAddress(int addressid)
        {
            if (addressid > 0)
            {
                var addressdetails = await _unitOfWork.address.GetById(addressid);
                if (addressdetails != null)
                {
                    _unitOfWork.address.Delete(addressdetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<Address> GetAddressById(int addressid)
        {
            if (addressid > 0)
            {
                var addressdetails = await _unitOfWork.address.GetById(addressid);
                if (addressdetails != null)
                {
                    return addressdetails;
                }
            }
            return null;
        }

        public async Task<IEnumerable<Address>> GetAllAddress()
        {
            var assdessdetailsList = await _unitOfWork.address.GetAll();
            return assdessdetailsList;
        }

        public async Task<bool> UpdateAddress(Address addressdetail)
        {
            if (addressdetail != null)
            {
                var address = await _unitOfWork.address.GetById(addressdetail.AddressId);
                if (address != null)
                {
                    address.AddressId = addressdetail.AddressId;
                    address.AddressName = addressdetail.AddressName;

                    _unitOfWork.address.Update(address);

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

