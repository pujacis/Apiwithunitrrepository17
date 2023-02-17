using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Models
{
    public class TaskPerson
    {
        [Key]
        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        [ForeignKey("country")]
        public int CountryId { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public string? Address { get; set; }
        public string? FileName { get; set; }
        public string? base64data { get; set; }

        public virtual  RepoWithCountry country { get;set;}
        public virtual RepoWithCity City { get; set; }
        public virtual RepoWithState State { get; set; }

    }
}
