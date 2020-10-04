using sygmaemrek.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace sygmaemrek.Services
{
    public class Foursquare : IFoursquare
    {
        string Base_url = "https://api.foursquare.com/v2/venues/search";
        string ClientID = "35T1HW10CZL14XOEHWANMY4SKBTXTJLZHBRWEOYT1UJZEMO2";
        string ClientSecrect = "SDICSHDE0FSCRDAOHSEOMMFQLHHKNSFSIMCKQ5KL0G4OZXXR";

        public async Task<Place> getvenue(double lat, double lon)
        {
            string ll = $"{lat},{lon}";
            int radius = 250;
            int limit = 10;
            int version = 20200424;

            string url = Base_url + $"?ll={ll}&radius={radius}&limit={limit}&v={version}&client_id={ClientID}&client_secret={ClientSecrect}";

            HttpClient client = new HttpClient();

            HttpResponseMessage respone = await client.GetAsync(url);

            if(respone.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await respone.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<Place>(result);

                return json;
            }

            return null;

        }
    }
}
