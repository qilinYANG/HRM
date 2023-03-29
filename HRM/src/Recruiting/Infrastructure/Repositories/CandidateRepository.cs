using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
	public class CandidateRepository :BaseRepository<Candidate>,ICandidateRepository
	{
		public CandidateRepository(RecruitingDbContext dbContext) : base(dbContext)
        {
		}
	}
}

