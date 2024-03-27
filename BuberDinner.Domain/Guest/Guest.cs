using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Host.ValueObjects;
using BuberDinner.Domain.Menu.ValueObjects;
using BuberDinner.Domain.User.Valuebjects;

namespace BuberDinner.Domain.Host;

public sealed class Guest : AggregateRoot<GuestId>
{
    public Guest(GuestId id) : base(id)
    {
    }
}