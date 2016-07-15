using System.Collections.Generic;

namespace ConsoleDemo.Visitor.v3
{
	class RequestsRepositoryVisitor : IVisitor
	{
		List<object> toSave = new List<object>();

		public void SaveChanges()
		{
			using (IUnitOfWork uof = UofFacotry.CreateUnitOfWork())
			{
				foreach (var entity in toSave)
				{
					uof.Add(entity);
				}

				uof.SaveChanges();
			}
			toSave.Clear();
		}

		public void VisitNewCustomerCommand(NewCustomerCommand customerCommand)
		{
			toSave.Add(customerCommand);
		}

		public void VisitNewSalesOrderCommand(NewSalesOrderCommand salesOrderCommand)
		{
			toSave.Add(salesOrderCommand);
		}

		public void VisitNewPurchaseOrderCommand(NewPurchaseOrderCommand purchaseOrder)
		{
			toSave.Add(purchaseOrder);
		}
	}
}