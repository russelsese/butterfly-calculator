using Butterfly.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Operators
{
	public class InvalidOperation : IOperation
	{
		private CalculateResponse result;
		public InvalidOperation()
		{
			result = new CalculateResponse()
			{
				Success = false,
				Value = 0,
				Message = "Invalid operation"
			};
		}

		public bool Validate(InputPayload payload)
		{
			return false;
		}

		public CalculateResponse Compute(InputPayload payload)
		{
			return result;
		}
	}
}