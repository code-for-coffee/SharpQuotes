using System;
using BCrypt;

namespace SharpQuotes
{
	public class User
	{
		public User(string name, string email, string password)
		{
			this.passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
		}
		private string passwordHash;
		public string username { get; set; }
		public string email { get; set; }
		public Boolean comparePassword(string userInput)
		{
			if (BCrypt.Net.BCrypt.Verify(userInput, this.passwordHash) == true) {
				return true;
			}
			return false;
		}
	}
}

