namespace ConsoleDemo.Visitor.v3
{
	public interface IVisitor
	{
		void VisitNewCustomerCommand(NewCustomerCommand customerCommand);
		void VisitNewSalesOrderCommand(NewSalesOrderCommand salesOrderCommand);
		void VisitNewPurchaseOrderCommand(NewPurchaseOrderCommand purchaseOrder);
	}
}