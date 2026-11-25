using System;
using System.Collections .Generic;
using System.Text;

namespace assignment_4
{
	public enum Genre { fiction,Nonfiction,Science }
	public class book
	{
		private string password = "secret";


		internal int CopiesInStock = 5;



		public string Title;



		public Genre Genre { get; set; }
	
		
	}
}

