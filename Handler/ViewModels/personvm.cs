﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.ViewModels
{
    public class personvm
    {
        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string? CountryName { get; set; }
        public string? SatateName { get; set; }
        public string? CityName { get; set; }
        public string? Address { get; set; }
        public string? FileName { get; set; }
        public string? base64data { get; set; }
    }
}
