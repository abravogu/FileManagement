﻿using NttDataFileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttDataFileManagamen.DataAccess.Repository.Contracts
{
    public interface IStudentRepository
    {

        bool Add(Student student);
    }
}
