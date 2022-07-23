using System.ComponentModel.DataAnnotations;
using System;
namespace Asp.netCoreMvcCrud.Models
{
    public class Conge
    {
        [Key]
        public int CongeId { get; set; }


        public Employee Employee
        {
            get; set;
        }

        [DataType(DataType.Date)]
        public DateTime dateDebut { get; set; }



        [DataType(DataType.Date)]
        public DateTime dateFin { get; set; }
    }
}
