using System;

namespace ConsoleDemo.Visitor.v3
{
	class SalesOrderCommandApprover : IVisitor
	{
		public void VisitNewSalesOrderCommand(NewSalesOrderCommand salesOrderCommand)
		{
			Console.WriteLine($"Sales Order from {salesOrderCommand.CustomerCode} was approved.");
		}

		public void VisitNewCustomerCommand(NewCustomerCommand customerCommand)
		{
		}

		public void VisitNewPurchaseOrderCommand(NewPurchaseOrderCommand purchaseOrder)
		{
		}
	}
}