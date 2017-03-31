using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibrary
{
    public class BookModel
    {


        public string title_suggest { get; set; }
        public string author_name { get; set; }
        public string cover_i { get; set; }
        public int first_publish_year { get; set; }
        
        public BookModel(string title_Suggest, string author_Name, string cover_Image, int first_Publish_Year)
        {
            title_suggest = title_Suggest;
            author_name = author_Name;
            cover_i = cover_Image;
            first_publish_year = first_Publish_Year;
        }

        public BookModel()
        {
        }
    }
}
