using System;

namespace ConsoleDemo.Visitor.v3
{
	class NewCustomerCommandApprover : IVisitor
	{
		private ICrmService crmService;

		public NewCustomerCommandApprover(ICrmService crmService)
		{
			this.crmService = crmService;
		}

		public void VisitNewCustomerCommand(NewCustomerCommand customerCommand)
		{
			Console.WriteLine($"We have new customer! {customerCommand.Name} wellcome!");
		}

		public void VisitNewSalesOrderCommand(NewSalesOrderCommand salesOrderCommand)
		{
		}

		public void VisitNewPurchaseOrderCommand(NewPurchaseOrderCommand purchaseOrder)
		{
		}

		public NewCustomerCommandApprover()
		{
		}
	}
}