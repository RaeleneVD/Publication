using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Publication.Models
{
	//DATABASE

	public class DataRepository //add info manually into repo
    {
			public static List<Publication> GetAllPublications()
			{
				var author1 = new Author { FirstName = "Jane", LastName = "Doe" };
                var author2 = new Author { FirstName = "John", LastName = "Smith" };

			return new List<Publication>
				{
                       new Article
                {
                    Author = new Author { FirstName = "Koffi", LastName = "Umukoro" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                    MainStoryURL = "https://bait.example.net/bag.aspx",
                    Summary = "Addison is a detective from Sale who falls in love with his best friend...",
                    Title = "Improving the foundation of our falling sand simulator",
                    DatePublished = new DateTime(2018, 7, 24)
                },
                new Book
                {
                    Author = new Author { FirstName = "Octavia", LastName = "Barret" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                    MainStoryURL = "https://www.example.com/bite.aspx",
                    Summary = "A farmer from Markham is delighted when she gets the chance to take part in X-Factor...",
                    Title = "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    Edition = 2,
                    DatePublished = new DateTime(2006, 5, 15)
                },
                new Article
                {
                    Author = new Author { FirstName = "Gunnhild", LastName = "Aric" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                    MainStoryURL = "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary",
                    Summary = "A caretaker from Lehi is delighted when she gets the chance to take part in X-Factor...",
                    Title = "When Your Smart ID Card Reader Comes with Malware",
                    DatePublished = new DateTime(2023, 3, 21)
                },
                new Book
                {
                    Author = new Author { FirstName = "Jakob", LastName = "Ayanda" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg",
                    MainStoryURL = "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement",
                    Summary = "In a world where robots are wealthy, one golfer has no choice but to assassinate...",
                    Title = "Jailer: A truly relational database tool",
                    Edition = 3,
                    DatePublished = new DateTime(1989, 6, 6)
                },
                new Article
                {
                    Author = new Author { FirstName = "Shyam", LastName = "Benson" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                    MainStoryURL = "https://www.example.com/bait/bath.php",
                    Summary = "In a world where robots are miraculously transformed into angels...",
                    Title = "Everything you ever wanted to know about terminal",
                    DatePublished = new DateTime(2020, 1, 23)
                },
                new Article
                {
                    Author = new Author { FirstName = "Lucas", LastName = "Asim" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                    MainStoryURL = "http://www.example.com/bear",
                    Summary = "When a movie star from West Des Moines learns to sing, not everybody is supportive...",
                    Title = "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                    DatePublished = new DateTime(2022, 10, 28)
                },
                new Article
                {
                    Author = new Author { FirstName = "Harmon", LastName = "Deeann" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                    MainStoryURL = "https://www.example.com/bells",
                    Summary = "A WW2 veteran Brisbane who receives an invitation to a modern battle...",
                    Title = "Husky, Datadog's Third-Generation Event Store",
                    DatePublished = new DateTime(2022, 3, 4)
                },
                new Book
                {
                    Author = new Author { FirstName = "Gargi", LastName = "Sudheer" },
                    LeadingImage = "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg",
                    MainStoryURL = "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument",
                    Summary = "In a world where vampires run large corporations...",
                    Title = "Singers and Vampires",
                    Edition = 2,
                    DatePublished = new DateTime(1972, 4, 24)
                }
            };
        }
		
	}
}