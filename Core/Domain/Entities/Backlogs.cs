using Core.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entities
{
    public class Backlogs
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Priorities Priority { get; set; }

        public bool IsActive { get; set; }

        public DateTime ActionOn { get; set; }
    }
}
