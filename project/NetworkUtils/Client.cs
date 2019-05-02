using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace project.NetworkUtils
{

    public class Response
    {
        public string operation { get; set; }
        public string expression { get; set; }
        public string result { get; set; }
    }


    public class Client
    {
        public Client(string operation, string expression)
        {
            this.Operation = operation;
            this.Expression = expression;
            this.Params = this.Operation + "/" + this.Expression;
        }

        private const string URL = "https://newton.now.sh/";
        private string Operation { get; set; }
        private string Expression { get; set; }
        private string Params { get; set; }

        public Response NewtonQuery()
        {
            Response result = null;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(Params).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                result = response.Content.ReadAsAsync<Response>().Result;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();
            return result;
        }
    }
}
