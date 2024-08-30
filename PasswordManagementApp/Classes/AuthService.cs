using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class AuthService
{
    private readonly string apiKey;  // Stores the Firebase API key.
    private readonly HttpClient httpClient;  // Creates an HttpClient instance for HTTP requests.

    // Constructor method, initializes the Firebase API key and the HttpClient instance.
    public AuthService(string firebaseApiKey)
    {
        apiKey = firebaseApiKey;
        httpClient = new HttpClient();
    }

    // Asynchronous method to perform user login.
    public async Task<string> SignInUserAsync(string email, string password)
    {
        // Firebase authentication API URL.
        var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}";

        // The request body contains email and password information. 
        // returnSecureToken ensures the token is returned.
        var requestBody = new
        {
            email = email,
            password = password,
            returnSecureToken = true
        };

        // The request body is converted to JSON format and encoded with UTF8 for the HTTP request.
        var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

        // Sends the HTTP POST request and waits for the response.
        var response = await httpClient.PostAsync(url, content);

        // If the response is successful, the user ID is retrieved and returned.
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var parsedResponse = JObject.Parse(jsonResponse);
            string userId = parsedResponse["localId"].ToString();  // Extracts the userId from the JSON response.
            return userId;
        }
        else
        {
            // Displays an error message in case of login failure.
            MessageBox.Show($"Login error. Please check your login information.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return "";
        }
    }
}
