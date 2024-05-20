﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableEntity<T> : BaseEntity
    {
        public Guid CreatedBy { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Guid DeletedBy { get; set; }

        protected AuditableEntity()
        {
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
}
