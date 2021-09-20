using Core.Application.Common;
using System;

namespace Core.Application.Commands.Backlogs
{
    public class CreateBacklogCommand
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Priorities Priority { get; set; }

        public bool IsActive { get; set; }

        public DateTime ActionOn { get; set; }
    }
}
