using System;
namespace SharpQuotes
{
	/// <summary>
	/// Quote models.
	/// </summary>
	public class Quote
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SharpQuotes.Quote"/> class.
		/// </summary>
		public Quote()
		{
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:SharpQuotes.Quote"/> class.
		/// </summary>
		/// <param name="author">Author.</param>
		/// <param name="text">Text.</param>
		public Quote(string author, string text)
		{
			this.author = author;
			this.text = text;
		}
		public string author { get; set; }
		public string text { get; set; }
	}
}

