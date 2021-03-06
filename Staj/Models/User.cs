using Microsoft.AspNetCore.Mvc;
using Staj.Models.ModelMetadataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Staj.Models
{
    [ModelMetadataType(typeof(UserMetadata))]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string Email { get; set; }
    }
}
