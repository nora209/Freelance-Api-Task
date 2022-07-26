﻿using App.DataAccessLayer.Repository.IssueRepo;
using App.DataAccessLayer.Repository.PatientRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPatientRepo PatientsRepo { get; }

        public IIssueRepo IssuesRepo { get; }
        public UnitOfWork(IPatientRepo patientsRepo, IIssueRepo issuesRepo)
        {
            PatientsRepo = patientsRepo;
            IssuesRepo = issuesRepo;
        }
    }
}
