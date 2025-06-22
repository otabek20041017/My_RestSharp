using System;
using RestSharp;
namespace Rest_Sharp_API
{
    public class Rest_Api
    {
        static void Main(string[] args)
        {
            // Create RestClient with API base URL
            var client = new RestClient("https://jsonplaceholder.typicode.com");

            // Create Get request for /posts/1
            var request = new RestRequest("/posts/1", Method.Get);
            var request2 = new RestRequest("/comments/1", Method.Get);

            // Execute request and get response
            var response = client.Execute(request);

            var comments_response = client.Execute(request2);
            // Checking the status and printing the response

            Console.WriteLine($"\nStatus: {response.StatusCode}");
            Console.WriteLine($"Content: {response.Content}");
            Console.WriteLine($"Post-Comments: {comments_response.Content}");
        }
    }
}
