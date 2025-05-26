using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Publication.Models
{
	public class Author
	{
		public string FirstName { get; set; }
        public string  LastName { get; set; }

		public string GetFullName()
		{
			return FirstName + " " + LastName;
		}
    }
}