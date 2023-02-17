using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Models
{
    public class TaskTrigger
    {
        [Key]
        public DateTime Latupdate { get; set; }
        public string? Oldpersonname { get; set; }
        public string? Newpersonname { get; set;}

    }
}
