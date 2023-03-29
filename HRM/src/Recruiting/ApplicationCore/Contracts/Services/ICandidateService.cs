using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
    public interface ICandidateService
    {

        Task addCandiate(CandidateRequestModel model);
    }
}
