namespace GymManagement.Application.CreateSubscription
{
    public interface ISubscriptionsService
    {
        Guid CreateSubscription(string subscriptionType, Guid adminId);
    }
}
