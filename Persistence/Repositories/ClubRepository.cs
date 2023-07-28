using Application.Interfaces.Repositories;
using Domain.Entities.FootBall;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly IGenericRepository<Club> _repository;

        public ClubRepository(IGenericRepository<Club> repository)
        {
            _repository = repository;
        }

    }
}
