using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioID { get; set; }
        
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "Nome é Obrigatório")]
        [DisplayName("Nome Completo")]
        public string NomeCompleto { get; set;}
        
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Empresa")]
        public string EmpCode { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Cargo { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string localizacao { get; set; }
    }
}
