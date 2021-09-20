using System;
using System.Collections.Generic;
using Core.Domain.Entities;

namespace Core.Domain.Interfaces
{
    public interface IBacklogRepository
    {
        IEnumerable<Backlogs> GetAll();

        Backlogs GetBy(int id);

        Backlogs Insert(Backlogs model);

        Backlogs Update(Backlogs model);

        void Delete(int id);
    }
}