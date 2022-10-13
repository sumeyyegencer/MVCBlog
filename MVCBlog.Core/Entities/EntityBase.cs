using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBlog.Core.Entities
{
    public abstract class EntityBase:IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; } //nullable
        public virtual string? DeletedBy { get; set; }  //nullable
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; } //nullable
        public virtual DateTime? DeletedDate { get; set; }  //nullable
        public virtual bool IsDeleted { get; set; } = false;
    }
}
