using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class AuthService
{
    private readonly string apiKey;
    private readonly HttpClient httpClient;

    public AuthService(string firebaseApiKey)
    {
        apiKey = firebaseApiKey;
        httpClient = new HttpClient();
    }

    public async Task<string> SignInUserAsync(string email, string password)
    {
        var url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}";
        var requestBody = new
        {
            email = email,
            password = password,
            returnSecureToken = true
        };

        var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync(url, content);

        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var parsedResponse = JObject.Parse(jsonResponse);
            string userId = parsedResponse["localId"].ToString(); // userId'yi çekiyoruz
            return userId;
        }
        else
        {
            throw new Exception($"Giriş hatası: {response.ReasonPhrase}");
        }
    }
}
