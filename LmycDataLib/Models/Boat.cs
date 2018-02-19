using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models
{
    class Boat
    {
        [Key]
        public int BoatId { get; set; }

        [Required]
        public string BoatName { get; set; }

        [Required]
        public string Picture { get; set; }

        [Required]
        public int LengthInFeet { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Year { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        [ForeignKey("User")]
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }
    }
}
