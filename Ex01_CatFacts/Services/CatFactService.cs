using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Ex01_CatFacts.Models;



namespace Ex01_CatFacts.Services
{
    public class CatFactService
    {
        private readonly HttpClient _httpClient;

        public CatFactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://catfact.ninja/fact");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Récupère des faits sur les chats
        /// </summary>
        /// <param name="path">Le chemin relatif de l'API (ex: "fact" ou "facts")</param>
        /// <returns>Une liste de faits sur les chats</returns>
        public async Task<List<CatFact>> GetCatFactAsync(string path)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CatFact>>(jsonResponse);
            }

            return new List<CatFact>();
        }
    }
}
