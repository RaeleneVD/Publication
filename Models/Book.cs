using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Publication.Models
{
	public class Book : Publication //Book inherits from Publication
	{
        //only book has edition 
        public int Edition { get; set; }

        //abstract class deinintion here. return publication type
        public override string GetPublicationType()
        {
            return "Book";
        }
    }
}