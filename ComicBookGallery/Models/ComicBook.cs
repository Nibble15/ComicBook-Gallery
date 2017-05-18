using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models {
    public class ComicBook {

        public int Id { get; set; }
        public string SeriesTitle { get; set; } 
        public int IssueNumber { get; set; } 
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText => $"{SeriesTitle} #{IssueNumber}";

        // NOTE: the following can also be done with the property getter syntax that the teacher used
        //public string CoverImageFileName {
        //    get {
        //        return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
        //    }
        //} 
        public string CoverImageFileName => $"{SeriesTitle.Replace(" ", "-").ToLower()}-{IssueNumber}.jpg";

    }
}