using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Models
{
    public  class RepoWithState
    {
        [Key]
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public int? CountryId { get; set; }
    }
}
