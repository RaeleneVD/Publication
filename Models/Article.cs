using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Publication.Models
{
	public class Article: Publication //Article inherits from Publication
	{
        //Define abstract class here. Return atricle as publication type
        public override string GetPublicationType()
        {
            return "Article";
        }
    }
}