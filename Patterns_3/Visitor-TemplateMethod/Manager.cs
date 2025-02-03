namespace Patterns_3.Visitor_TemplateMethod;
using System;
using System.Collections.Generic;

// Order manager class
class OrderManager
{
    private List<Order> _orders = new List<Order>();
    private List<IOrderVisitor> _visitors = new List<IOrderVisitor>();
    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public void AddVisitor(IOrderVisitor visitor)
    {
        _visitors.Add(visitor);
    }

    public void ProcessOrders()
    {
        foreach (var order in _orders)
        {
            // Template Method Pattern: Process the order
            order.ProcessOrder();

            // Visitor Pattern: Apply visitors to the order
            foreach (var visitor in _visitors)
            {
                if (order is StandardOrder standardOrder)
                    visitor.Visit(standardOrder);
                else if (order is ExpressOrder expressOrder)
                    visitor.Visit(expressOrder);
                else if (order is WholesaleOrder wholesaleOrder)
                    visitor.Visit(wholesaleOrder);
            }
        }
    }
}