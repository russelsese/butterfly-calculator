using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Butterfly.Calculator;
using Butterfly.Calculator.Controllers;

namespace Butterfly.Calculator.Tests.Controllers
{
	[TestClass]
	public class CalculateControllerTest
	{
		[TestMethod]
		public void When_InvalidOperation()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "invalid operation",
				Value1 = -1,
				Value2 = 1,
			});
			Assert.IsFalse(response.Success);
			Assert.AreEqual(response.Message, "Invalid operation");
		}

		[TestMethod]
		public void When_InvalidParameter()
		{
			CalculateController controller = new CalculateController();
			//Pass null parameter
			var response = controller.Post(null);
			Assert.IsFalse(response.Success);
			Assert.AreEqual(response.Message, "Invalid parameter");
		}


		[TestMethod]
		public void When_Add_OneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "add",
				Value1 = 1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value,2);
		}

		[TestMethod]
		public void When_Add_NegativeOneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "add",
				Value1 = -1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, 0);
		}


		[TestMethod]
		public void When_Subtract_OneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "subtract",
				Value1 = 1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, 0);
		}

		[TestMethod]
		public void When_Subtract_NegativeOneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "subtract",
				Value1 = -1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value,-2);
		}


		[TestMethod]
		public void When_Multiply_OneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "multiply",
				Value1 = 1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, 1);
		}

		[TestMethod]
		public void When_Multiply_NegativeOneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "multiply",
				Value1 = -1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, -1);
		}

		[TestMethod]
		public void When_Divide_OneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "multiply",
				Value1 = 1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, 1);
		}

		[TestMethod]
		public void When_Divide_NegativeOneAndOne()
		{

			CalculateController controller = new CalculateController();

			var response = controller.Post(new Models.InputPayload()
			{
				Operation = "multiply",
				Value1 = -1,
				Value2 = 1,
			});
			Assert.IsTrue(response.Success);
			Assert.AreEqual(response.Value, -1);
		}
	}
}
