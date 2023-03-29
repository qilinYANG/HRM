using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class JobService : IJobService
{
    private readonly IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async  Task< List<JobResponseModel>> GetAllJobs()
    {
        var jobs = await _jobRepository.GetAllJobs();

        var jobsResponseModel = new List<JobResponseModel>();

        foreach (var job in jobs)
            jobsResponseModel.Add(new JobResponseModel
            {
                Id = job.Id, Description = job.Description, Title = job.Title,
                StartDate = job.StartDate.GetValueOrDefault(), NumberOfPositions = job.NumberOfPositions,
                //Status = job.JobStatusLookUp.JobStatusCode
            });

        return jobsResponseModel;
    }

    public async  Task< JobResponseModel> GetJobById(int id)
    {
        var job = await _jobRepository.GetJobById(id);
        var jobResponseModel = new JobResponseModel
        {
            Id = job.Id, Title = job.Title, StartDate = job.StartDate.GetValueOrDefault(), Description = job.Description, NumberOfPositions = job.NumberOfPositions
        };
        return jobResponseModel;
    }

    public async Task<int> AddJob(JobRequestModel model)
    {
        // call the repository that will use EF Core to save the data
        String status = model.Status;
        int id = 1;
        if (status == "close")
        {
            id = 2;
        }
        if (status == "pending")
            id = 3;

        var jobEntity = new Job
        {
            Title = model.Title, StartDate = model.StartDate, Description = model.Description,
            CreatedOn = DateTime.UtcNow, NumberOfPositions = model.NumberOfPositions,
            JobStatusLookUpId = id
            

            
        };

       var job = await _jobRepository.AddAsync(jobEntity);
       return job.Id;
    }
}