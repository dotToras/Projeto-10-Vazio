using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto10Vazio.Models
{
    public class modelLogin
    {

        public int Cod { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

    }
}