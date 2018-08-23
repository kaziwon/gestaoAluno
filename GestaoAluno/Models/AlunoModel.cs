using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoAluno.Models
{
    public class AlunoModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int RM { get; set; }
    }
}