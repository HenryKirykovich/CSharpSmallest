using System.Net.Http;  // For sending HTTP requests
using System.Net.Http.Headers;   // For setting headers like Authorization
using System.Threading.Tasks;   // To use async/await for asynchronous operations



class Program
{
    static async Task Main()
    {
        var start = DateTime.Now;
        Console.WriteLine("Process start: " + start.ToLongDateString());
        Console.WriteLine("Your converter .mp3-to-Doc");
        string filePath = @"C:\Users\info\Desktop\audio.mp3";
        string apiKey = "use_own_key";

        using var httpClient = new HttpClient();   // nitializes an HTTP client.
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",apiKey);   // Adds your API key to the Authorization header as a Bearer token.

        var form = new MultipartFormDataContent(); // Creates a form that can send files and fields

        var fileBytes = File.ReadAllBytes(filePath); // Reads the audio file into a byte array.

        var fileContent = new ByteArrayContent(fileBytes);   // Wraps the byte array as HTTP content and sets its media type to audio/mpeg
        fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg");

        form.Add(fileContent, "file", Path.GetFileName(filePath)); // Adds the file content to the form with a name and filename. 
        form.Add(new StringContent("whisper-1"), "model"); // Adds the model name to the form as a string content.

        Console.WriteLine("Please Wiat...");

        var response = await httpClient.PostAsync("https://api.openai.com/v1/audio/transcriptions", form);  // Sends a POST request with the form to OpenAI's transcription API.
        
        
        var result = await response.Content.ReadAsStringAsync(); // Reads the response content as a string asynchronously.

        Console.WriteLine("Response from OpenAI:\n");
        Console.WriteLine(result); // Prints the response from OpenAI to the console.


        // Save as .txt file with line breaks

        File.WriteAllText(@"C:\Users\info\Desktop\transcription.txt", result);
        Console.WriteLine("Saved to transcription.txt");

       
        
        Console.WriteLine("\nJobe is done: transcription.txt");
        Console.WriteLine("End time: " + DateTime.Now.ToLongTimeString());
        Console.WriteLine("Duration: " + (DateTime.Now - start).TotalSeconds + " seconds");
    }



}
