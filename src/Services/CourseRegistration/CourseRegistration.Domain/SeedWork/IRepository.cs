﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain.SeedWork
{
    public interface IRepository<T>
        where T : IAggregateRoot
    {
    }
}
