using Butterfly.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Operators
{
	public class Calculator
	{
		private readonly IOperation operation;
		public Calculator(IOperation operation)
		{
			this.operation = operation;
		}

		public CalculateResponse Compute(InputPayload payload)
		{
			return operation.Compute(payload);
		}
	}
}