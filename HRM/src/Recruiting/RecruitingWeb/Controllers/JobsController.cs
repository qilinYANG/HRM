using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        public IActionResult Index()
        {
            // we need to get list of Jobs
            // call the Job Service
           // var jobsController = new JobController(new JobService());
           // jobsController.Index();
           
            var jobs = _jobService.GetAllJobs();
            return View();
        }

        public IActionResult Details(int id)
        {
            // get job by Id
          
            var job = _jobService.GetJobById(id);
            return View();
        }
    }
}