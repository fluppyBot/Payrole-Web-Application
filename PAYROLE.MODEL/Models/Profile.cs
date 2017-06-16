using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class Profile
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string FirsName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }

        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
    }

   
}
