using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MangaCollection.Models
{
    public class Manga
    {
        public int Id { get; set; }
        public string SerTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Contributer[] Contributers { get; set; }
        public bool Favorite { get; set; }
    }
}