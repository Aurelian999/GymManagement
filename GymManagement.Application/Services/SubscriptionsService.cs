namespace GymManagement.Application.CreateSubscription
{
    public class SubscriptionsService : ISubscriptionsService
    {
        public Guid CreateSubscription(string subscriptionType, Guid adminId)
        {
            return Guid.NewGuid();
        }
    }
}
