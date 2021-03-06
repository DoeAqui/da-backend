using DoeAqui.Domain.AggregateModels.ProductAggregate.Enums;
using DoeAqui.Domain.Core.Events;

namespace DoeAqui.Domain.AggregateModels.ProductAggregate.Events
{
    public abstract class BaseProductEvent : Event
    {
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public int Quantity { get; protected set; }
        public string Size { get; protected set; }
        public EStatus Status { get; protected set; }
        public EFreight Freight { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}