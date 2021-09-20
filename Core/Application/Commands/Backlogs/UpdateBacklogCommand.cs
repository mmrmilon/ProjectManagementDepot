using Core.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.Commands.Backlogs
{
    public class UpdateBacklogCommand
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Priorities Priority { get; set; }

        public bool IsActive { get; set; }
    }
}
