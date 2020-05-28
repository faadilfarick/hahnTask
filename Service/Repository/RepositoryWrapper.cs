using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IApplicantRepository _applicant;

        public IApplicantRepository Applicant
        {
            get
            {
                if (_applicant == null)
                {
                    _applicant = new ApplicantRepository(_repoContext);
                }

                return _applicant;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
