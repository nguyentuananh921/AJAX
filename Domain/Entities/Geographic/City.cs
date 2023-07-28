using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities.Geographic
{
    public class City : AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        [Required]
        [MaxLength(75)]
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
