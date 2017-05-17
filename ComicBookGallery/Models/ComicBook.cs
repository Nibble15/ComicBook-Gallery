using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models {
    public class ComicBook {

        public int Id { get; set; }
        public string SeriesTitle { get; set; } 
        public string IssueNumber { get; set; } 
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText => SeriesTitle + " #" + IssueNumber;

        //if problem with the following property return to "updating the data Model"
        // on the treehouse mvc course and replace with his version of 
        // the property which is a readonly - remember that it has a getter..
        public string CoverImageFileName => $"{SeriesTitle.Replace(" ", "-").ToLower()} " +
                      $"- {IssueNumber} .jpg";

    }
}