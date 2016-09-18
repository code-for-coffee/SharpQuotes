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
	public class UserTest
	{
		[Test]
		public void ConstructorTest()
		{
			// Arrange
			var model = new User("thomas", "thomas@dragonkin.org", "one_kilo781");

			// Assert
			Assert.AreEqual("thomas", model.username);
			Assert.AreEqual("thomas@dragonkin.org", model.email);
		}
		[Test]
		public void CompareValidPasswordTest()
		{
			// Arrange
			var validPassword = "one_kilo781";
			var model = new User("thomas", "thomas@dragonkin.org", validPassword);

			// Assert
			Assert.AreEqual(true, model.comparePassword(validPassword));
		}
		[Test]
		public void CompareInvalidPasswordTest()
		{
			// Arrange
			var validPassword = "one_kilo781";
			var invalidPassword = "wtfl33th4xx0rz";
			var model = new User("thomas", "thomas@dragonkin.org", validPassword);

			// Assert
			Assert.AreEqual(false, model.comparePassword(invalidPassword));
		}
	}
}

