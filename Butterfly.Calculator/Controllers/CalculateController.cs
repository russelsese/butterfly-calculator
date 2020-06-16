using Butterfly.Calculator.Models;
using Butterfly.Calculator.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Butterfly.Calculator.Controllers
{
    public class CalculateController : ApiController
    {
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


		[HttpPost]
		public CalculateResponse Post(InputPayload payload)
		{
			CalculateResponse response = null;
			//Log all requests
			log.Info(string.Format("HttpPost requested {0}", new JavaScriptSerializer().Serialize(payload)));
			Operators.Calculator Calculator = null;
			try
			{
				switch (payload.Operation)
				{
					case "add":
						log.Info("Add operation executed");
						Calculator = new Operators.Calculator(new Operators.Add());
						break;
					case "subtract":
						log.Info("Subtract operation executed");
						Calculator = new Operators.Calculator(new Operators.Subtract());
						break;
					case "multiply":
						log.Info("Multiply operation executed");
						Calculator = new Operators.Calculator(new Operators.Multiply());
						break;
					case "divide":
						log.Info("Divide operation executed");
						Calculator = new Operators.Calculator(new Operators.Divide());
						break;
					default:
						log.Error(string.Format("Invalid operation {0}", payload.Operation));
						Calculator = new Operators.Calculator(new Operators.InvalidOperation());
						break;
				}
			}
			catch (Exception ex)
			{
				//log invalid paramter passing
				log.Error(string.Format("Exception error occur {0}", ex.Message));
				Calculator = new Operators.Calculator(new Operators.InvalidParameter());
			}

			response = Calculator.Compute(payload);
			log.Info(string.Format("HttpPost response {0}", new JavaScriptSerializer().Serialize(response)));
			return response;
		}

		[HttpGet]
		public dynamic Get()
		{
			//Log get requests
			log.Info("HttpGet requested");
			return Request.CreateResponse(HttpStatusCode.NotFound);
		}

	}
}
