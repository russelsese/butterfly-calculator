using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Models
{
	public class CalculateResponse
	{
		public bool Success { get; set; }
		public double Value { get; set; }
		public string Message { get; set; }

		public CalculateResponse()
		{
			Success = true;
			Value = 0;
			Message = string.Empty;
		}
	}
}