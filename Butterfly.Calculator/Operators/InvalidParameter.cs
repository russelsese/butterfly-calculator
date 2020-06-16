using Butterfly.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Operators
{
	public class InvalidParameter : IOperation
	{
		private CalculateResponse result;
		public InvalidParameter()
		{
			result = new CalculateResponse()
			{
				Success = false,
				Value = 0,
				Message = "Invalid parameter"
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