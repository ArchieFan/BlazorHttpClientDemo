using HttpClientDemo.Data;
using Microsoft.AspNetCore.Components;

namespace HttpClientDemo.Pages
{
    public partial class CoinsData
    {
        CoinsList? coinslist;
        string? errorString;

        [Inject]
        public IHttpClientFactory? _clientFactory { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //var request = new HttpRequestMessage(HttpMethod.Get,
            //    "https://nova.bitcambio.com.br/api/v3/public/getassets");
            //var client = _clientFactory.CreateClient();
            //HttpResponseMessage response = await client.SendAsync(request);
            //if (response.IsSuccessStatusCode) {
            //    coinslist = await response.Content.ReadFromJsonAsync<CoinsList>();
            //    errorString = null;
            //} else {
            //    errorString = $"There was an error getting our assets. { response.ReasonPhrase } ";
            //}

            var client = _clientFactory!.CreateClient("Coins");
            try
            {
                coinslist = await client.GetFromJsonAsync<CoinsList>(
                    "getassets");
                errorString = null;
            }
            catch (Exception ex)
            {
                errorString = $"There was an error getting our assets. {ex.Message} ";
            }
        }
    }
}
