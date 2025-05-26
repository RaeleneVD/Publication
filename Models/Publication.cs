using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Publication.Models
{
	public abstract class Publication //has abstract classes
	{
        public string LeadingImage { get; set; } //image?
		public string Title { get; set; }
        public string Summary { get; set; }
        public string MainStoryURL { get; set; }
        public Author Author { get; set; }  //object
        public DateTime DatePublished { get; set; }  //object

        public abstract string GetPublicationType(); //anstract--> inheriting class must create

        public string GetDateFormat()
        {
            return DatePublished.ToString("yyyy-MM-dd");
        }
    }
}