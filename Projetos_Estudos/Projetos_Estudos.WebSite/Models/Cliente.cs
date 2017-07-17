using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projetos_Estudos.WebSite.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NomeCompletoRazaoSocial { get; set; }
        
        [StringLength(255)]
        public string ApelidoNomeFantasia { get; set; }

        [Required]
        [StringLength(15)]
        public string CPFCNPJ { get; set; }       
        
    } 
}