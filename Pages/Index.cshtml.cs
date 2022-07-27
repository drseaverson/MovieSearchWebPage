using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie_Search_Tool.Models;
using System.Net.Http.Json;
using System.Net.Http;

namespace Movie_Search_Tool.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        static HttpClient client = new HttpClient();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string userInput { get; set; }
        public string movieTitle { get; set; }
        public MovieDataModel movies { get; set; }
        public bool buttonClicked { get; set; }
        public string error { get; set; }
        public string loading { get; set; }

        //extra method called above to separate API call from button click
        /*async Task<MovieDataModel> GetRequest()
        { //method is called when user clicks search button
            string path = "https://api.themoviedb.org/3/search/movie?api_key=62265a6e5fdc417f4a203063677000d5&query=Avengers"; //initial request from movie API

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                System.Diagnostics.Debug.WriteLine("Status Code Success");
                movies = await response.Content.ReadFromJsonAsync<MovieDataModel>();
                buttonClicked = false;
                System.Diagnostics.Debug.WriteLine(movies.total_Pages.ToString());
            }
            else
            {
                error = $"There was an error retrieving any movies: { response.ReasonPhrase }";
            }
            return movies;
        }*/
    }
}