using Butterfly.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly.Calculator.Operators
{
	public interface IOperation
	{
		bool Validate(InputPayload payload);
		CalculateResponse Compute(InputPayload payload);
	}
}
