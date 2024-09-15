using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace GetReq
{
    
        public class HttpClientExample
        {

            private static readonly HttpClient client = new HttpClient();   // readonly: The field can be assigned a value only once, either at the time of declaration or within a constructor of the class. After that, it cannot be modified.

        public static async Task Main(string[] args)
            {
                Console.WriteLine("Welcome to a Get Request");
                await GetRequestAsync();
                Console.ReadLine();

            }

            public static async Task GetRequestAsync()
            // async: This modifier indicates that the method contains asynchronous operations. It allows the use of await within the method.
            // Task: Represents an asynchronous operation that can be awaited.A method that returns Task does not return a value but can be awaited for completion.


            {
            try
            {
                string url = "https://httpstat.us/200";   // send the URL    
                
                //For testing HTTP GET requests and receiving different HTTP status codes (like 200, 404, 500, etc.), you can use public APIs designed for such purposes. Here are a few examples:

                //httpstat.us: This is a useful service that returns specific HTTP status codes based on the URL you request.
                //URL for a 200 OK response: https://httpstat.us/200
                //URL for a 404 Not Found response: https://httpstat.us/404
                //URL for a 500 Internal Server Error response: https://httpstat.us/500
                     


                HttpResponseMessage response = new HttpResponseMessage();  // class return dates to HttpResponse object

                response = await client.GetAsync(url);  //Send Get request and return dates


                // await 
                // It can only be used in methods marked with the async modifier.
                // It allows the program to remain responsive (non-blocking) by returning control to the caller until the awaited task completes.



                response.EnsureSuccessStatusCode();  // Ensure response status is successful  This method throws an exception if the response status code indicates an error.

                string responseBody = await response.Content.ReadAsStringAsync();   //read the response content as a string  // 

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
                {
                Console.WriteLine("Request error: " + e.Message);
                }

            }

            

        }
   
}
