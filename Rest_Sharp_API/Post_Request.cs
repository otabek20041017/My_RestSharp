using System;
using RestSharp;

namespace Rest_Sharp_API
{
    public class Post_Request
    {


        static void Main(string[] args)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("posts", Method.Post);

            request.AddJsonBody(new
            {
                userId = 1,
                title = "Otabek API testing on C#",
                body = "Hey RestSharp POST!"
            });

            var response = client.ExecuteAsync(request).Result;

            Console.WriteLine("POST: Response Code - " + response.StatusCode);
            Console.WriteLine("POST: Response Body - " + response.Content);
        }
    }
}
