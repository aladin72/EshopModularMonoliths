 

namespace Shared.DDD
{
    public interface IAggregrate<T> : IAggregrate, IEntity<T>
    {

    }
    public interface IAggregrate : IEntity
    {
            IEnumerable<IDomainEvent> DomainEvents { get; }
        IDomainEvent[] ClearDomainEvents();
    }
}
