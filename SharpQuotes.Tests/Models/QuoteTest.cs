using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SharpQuotes;
using SharpQuotes.Controllers;

namespace SharpQuotes.Tests
{
	[TestFixture]
	public class QuoteTest
	{
		[Test]
		public void EmptyConstructorTest()
		{
			// Arrange
			var model = new Quote();
			model.author = "Douglas Adams";
			model.text = "Don't panic";

			// Assert
			Assert.AreEqual("Douglas Adams", model.author);
			Assert.AreEqual("Don't panic", model.text);
		}
		public void ConstructorTest()
		{
			// Arrange
			var model = new Quote("Douglas Adams", "Don't panic");

			// Assert
			Assert.AreEqual("Douglas Adams", model.author);
			Assert.AreEqual("Don't panic", model.text);
		}
	}
}

