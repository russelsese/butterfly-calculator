using Butterfly.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Operators 
{
	public class Multiply : IOperation
	{
		private CalculateResponse result;

		public Multiply()
		{
			result = new CalculateResponse();
		}

		public bool Validate(InputPayload payload)
		{

			if ((payload.Value1 == float.MinValue) || (payload.Value2 == float.MinValue))
			{
				result.Success = false;
				result.Message = "Invalid parameter value";
				return false;
			}
			else
			{
				return true;
			}
		}

		public CalculateResponse Compute(InputPayload payload)
		{
			if (Validate(payload))
			{
				result.Value = payload.Value1 * payload.Value2;
			}
			return result;
		}

	}
}