using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string? AddressName { get; set; }

    }
}
