using System;
namespace SharpQuotes
{
	public class Quote
	{
		public Quote()
		{
		}
		public Quote(string author, string text)
		{
			this.author = author;
			this.text = text;
		}
		public string author { get; set; }
		public string text { get; set; }
	}
}

