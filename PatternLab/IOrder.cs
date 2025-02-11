using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLab
{
    // Паттерн Decorator
    public interface IOrder
    {
        decimal GetPrice();
        string GetDescription();
    }

    public class BaseOrder : IOrder
    {
        public decimal Price { get; set; } = 100;

        public decimal GetPrice() => Price;
        public string GetDescription() => "Базовый заказ";
    }

    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        protected OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public virtual decimal GetPrice() => _order.GetPrice();
        public virtual string GetDescription() => _order.GetDescription();
    }

    public class ExpressDelivery : OrderDecorator
    {
        public ExpressDelivery(IOrder order) : base(order) { }

        public override decimal GetPrice() => _order.GetPrice() + 30;
        public override string GetDescription() => _order.GetDescription() + ", Оперативная доставка";
    }

    public class GiftWrap : OrderDecorator
    {
        public GiftWrap(IOrder order) : base(order) { }

        public override decimal GetPrice() => _order.GetPrice() + 20;
        public override string GetDescription() => _order.GetDescription() + ", Упаковка подарков";
    }
}
