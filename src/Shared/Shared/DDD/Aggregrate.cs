

namespace Shared.DDD
{
    public abstract class Aggregrate<TID> : Entity<TID>, IAggregrate<TID>
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        public IEnumerable<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public IDomainEvent[] ClearDomainEvents()
        {
            IDomainEvent[] dequedEvents = _domainEvents.ToArray();
            _domainEvents.Clear();
            return dequedEvents;
        }
    }
}
