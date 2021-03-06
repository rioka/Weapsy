using System;
using Weapsy.Domain.Modules;

namespace Weapsy.Domain.Data.SqlServer.Entities
{
    public class Module : IDbEntity
    {
        public Guid SiteId { get; set; }
        public Guid ModuleTypeId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ModuleStatus Status { get; set; }

        public virtual Site Site { get; set; }
        public virtual ModuleType ModuleType { get; set; }
    }
}