using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreMvcCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Nom")]
        public string Nom { get; set; }

        public ICollection<Conge> conges { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Salaire")]
        public string Salaire { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

      

    }
}
