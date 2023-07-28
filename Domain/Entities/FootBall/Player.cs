using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.FootBall
{
    public class Player:BaseAuditableEntity
    {
        public string Name { get; set; }
        public int? ShirtNo { get; set; }
        public int? ClubId { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
