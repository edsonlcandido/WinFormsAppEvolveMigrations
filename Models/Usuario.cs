using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEvolveMigrations.Models
{
    internal class Usuario
    {
        //use data anotation to set primary key using GUID
        [Key]
        public string GUID { get; set; }
        //use data anotation to set required field, and set max length to 50 characters and min length to 3 characters
        [Required, MaxLength(50), MinLength(3)]
        public string Nome { get; set; }

    }
}
