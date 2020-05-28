using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IRepositoryWrapper
    {
        IApplicantRepository Applicant { get; }
        void Save();
    }
}
