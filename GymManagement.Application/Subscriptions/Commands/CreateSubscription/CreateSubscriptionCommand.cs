using MediatR;

namespace GymManagement.Application.Subscription.Commands.CreateSubscription;
public record CreateSubscriptionCommand(string SubscriptionType, Guid AdminId) : IRequest<Guid>;