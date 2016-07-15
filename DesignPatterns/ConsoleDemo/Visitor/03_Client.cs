﻿using System.Collections.Generic;

namespace ConsoleDemo.Visitor.v3
{
	public class CommandsManager3
	{
		private readonly List<IVisitable> items = new List<IVisitable>();

		public CommandsManager3()
		{
			this.items.AddRange(DemoData.GetItems());
		}

		public void PrettyPrint()
		{
			ReportVisitor report = new ReportVisitor();
			foreach (var item in items)
			{
				item.Accept(report);
			}

			report.Print();
		}

		public void ApproveAll()
		{
			IVisitor[] visitors = GetApproveVisitors();
			foreach (var item in items)
			{
				foreach (var visitor in visitors)
				{
					item.Accept(visitor);
				}
			}
		}

		private IVisitor[] GetApproveVisitors()
		{
			return new IVisitor[]
			{
				new NewCustomerCommandApprover(),
				new PurchaseOrderCommandApprover(),
				new SalesOrderCommandApprover()
			};
		}
	}
}