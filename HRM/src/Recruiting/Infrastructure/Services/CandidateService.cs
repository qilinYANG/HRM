using System;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services
{
	public class CandidateService:ICandidateService
	{

		private readonly ICandidateRepository _candidateRepository;

		public CandidateService(ICandidateRepository candidateRepository)
		{
			_candidateRepository = candidateRepository;
		}

		public async Task addCandiate(CandidateRequestModel model)
		{
			var CandidateEntities = new Candidate
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Email = model.Email

			};
			await _candidateRepository.AddAsync(CandidateEntities);

		}
	}
}

