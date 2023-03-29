using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class CandidateRequestModel
    {
      
        [StringLength(256)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(512)]
        public string Email { get; set; }

        public class ResumeFileProperties
        {
            public string FileName { get; set; }
            public string ContentType { get; set; }
            public FileInfo FileInfo { get; set; }
        }

        public ResumeFileProperties resume { get; set; }
        

    }
}

