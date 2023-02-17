using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Models
{
    public class RepoWithCountry
    {
        [Key]
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
    }
}
