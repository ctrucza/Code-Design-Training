using System;

namespace ConsoleDemo.Visitor.v3
{
class PurchaseOrderCommandApprover : IVisitor
{
	public void VisitNewPurchaseOrderCommand(NewPurchaseOrderCommand purchaseOrder)
	{
		Console.WriteLine($"Purchase of: {purchaseOrder.Product.Name} was approved.");
	}

	public void VisitNewCustomerCommand(NewCustomerCommand customerCommand)
	{
	}

	public void VisitNewSalesOrderCommand(NewSalesOrderCommand salesOrderCommand)
	{
	}
}
}