using Project.Core.Domain.Subscriptions;

namespace Project.Services.Test
{
    public interface ITestService
    {
        Task<IEnumerable<SubscriptionPlan>> GetAll();
    }
}