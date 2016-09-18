using System;
using BCrypt;

namespace SharpQuotes
{
	/// <summary>
	/// User model that utilizes BCrypt for password hashing.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SharpQuotes.User"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="email">Email.</param>
		/// <param name="password">Password.</param>
		public User(string name, string email, string password)
		{
			this.username = name;
			this.email = email;
			this.passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
		}
		private string passwordHash;
		public string username { get; set; }
		public string email { get; set; }
		/// <summary>
		/// Compares an input password to the model's hash.
		/// </summary>
		/// <returns><c>true</c>, if password was compared, <c>false</c> otherwise.</returns>
		/// <param name="userInput">User input.</param>
		public Boolean comparePassword(string userInput)
		{
			if (BCrypt.Net.BCrypt.Verify(userInput, this.passwordHash) == true) {
				return true;
			}
			return false;
		}
	}
}

