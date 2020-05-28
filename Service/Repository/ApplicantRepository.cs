using Data;
using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ApplicantRepository : RepositoryBase<Applicant>, IApplicantRepository
    {
        public ApplicantRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
