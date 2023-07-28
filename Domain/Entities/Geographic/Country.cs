using Domain.Common;
using Domain.Entities.FootBall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Geographic
{
    public class Country : AuditableBaseEntity
    {
        public Country()
        {
            Players = new List<Player>();
            Stadiums = new List<Stadium>();
        }
        public string Name { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public string FlagUrl { get; set; }
        public int? DisplayOrder { get; set; }

        public IList<Player> Players { get; set; }
        public IList<Stadium> Stadiums { get; set; }
    }
}
