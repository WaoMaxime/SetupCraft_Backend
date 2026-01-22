namespace Domain.Shared;

public interface IDomainEventDispatcher
{
    Task Dispatch(CancellationToken cancellationToken);
}
