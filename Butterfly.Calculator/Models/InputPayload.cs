using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Butterfly.Calculator.Models
{
	public class InputPayload
	{
		public string Operation { get; set; }
		public double Value1 { get; set; }
		public double Value2 { get; set; }

		public InputPayload()
		{
			Value1 = float.MinValue;
			Value1 = float.MinValue;
		}
	}
}