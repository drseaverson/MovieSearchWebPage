namespace Movie_Search_Tool.Models
{

    public class MovieDataModel
    {
        public Result[] results { get; set; }
        public int total_results { get; set; }
        public int total_Pages { get; set; }
    }

    public class Result
    {
        public bool adult { get; set; }
        public string overview { get; set; }
        public string release_Date { get; set; }
        public int?[] genre_Ids { get; set; }
        public string original_Language { get; set; }
        public string title { get; set; }
        public float vote_Average { get; set; }
    }



}
