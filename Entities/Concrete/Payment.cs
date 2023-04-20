using Core.Entities;

namespace Entities.Concrete;

public class Payment : IEntity
{
    public decimal Amount { get; set; }
}