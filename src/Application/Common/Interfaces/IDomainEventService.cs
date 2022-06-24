using cleanddd.Domain.Common;
using System.Threading.Tasks;

namespace cleanddd.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
