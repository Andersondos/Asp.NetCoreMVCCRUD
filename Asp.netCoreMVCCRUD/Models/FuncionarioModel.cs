using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Asp.netCoreMVCCRUD.Models
{
    public class FuncionarioModel
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

        [DisplayName("E-mail")]
        [Required(ErrorMessage ="E-mail é Obrigatótio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Senha é Obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DisplayName("Lembre-me")]
        public bool Lembreme { get; set; }


        //public string ValidarLogin()
        //{
        //    FuncionarioContext obj = new FuncionarioContext();


        //    return false;

        //}
    }
}
