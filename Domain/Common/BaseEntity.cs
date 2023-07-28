using Domain.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class BaseEntity:IEntity
    {
        private readonly List<BaseEvent> _domainEvents = new();

        public int Id { get; set; }


        //https://www.ezzylearning.net/tutorial/building-asp-net-core-apps-with-clean-architecture
        //https://github.com/ezzylearning/CleanArchitectureDemo/blob/main/CleanArchitectureDemo.Domain/Common/BaseEntity.cs


        [NotMapped]
        public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(BaseEvent domainEvent) => _domainEvents.Add(domainEvent);
        public void RemoveDomainEvent(BaseEvent domainEvent) => _domainEvents.Remove(domainEvent);
        public void ClearDomainEvents() => _domainEvents.Clear();
    }
}
