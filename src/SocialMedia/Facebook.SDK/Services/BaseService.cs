using Facebook.SDK.Arguments.Responses;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using prmToolkit.NotificationPattern;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook.SDK.Services
{
    public abstract class BaseService : Notifiable
    {
        protected readonly FacebookOptions FacebookOptions;
        protected readonly RestClient RestClient;

        protected BaseService(FacebookOptions facebookOptions)
        {
            FacebookOptions = facebookOptions;
            this.RestClient = new RestClient("https://graph.facebook.com/");
        }



        /// <summary>
        /// Verifica se à permissão suficiente configurada para realizar a função desejada
        /// </summary>
        /// <returns>boolean</returns>
        /// <param name="scopes">Permissões que devem ser testadas</param>
        protected bool HasPermission(params string[] scopes)
        {
            scopes?.ToList().ForEach(x =>
            {
                if (!this.FacebookOptions.Scope.Contains(x))
                {
                    this.AddNotification(x, $"Permissão {x} é necessária para executar função");
                }
            });

            return this.IsValid();
        }


        protected TResponse Get<TResponse>(string endpoint) where TResponse : class
        {
            var response = RequestWithOutJsonBody(endpoint, Method.GET);
            return GetResponseContent<TResponse>(response);
        }

        protected TResponse Post<TResponse>(string endpoint, object content) where TResponse : class
        {
            var response = RequestWithJsonBody(endpoint, content, Method.POST);
            return GetResponseContent<TResponse>(response);
        }

        protected TResponse Put<TResponse>(string endpoint, object content) where TResponse : class
        {
            var response = RequestWithJsonBody(endpoint, content, Method.PUT);
            return GetResponseContent<TResponse>(response);
        }

        protected TResponse Delete<TResponse>(string endpoint) where TResponse : class
        {
            var response = RequestWithOutJsonBody(endpoint, Method.DELETE);
            return GetResponseContent<TResponse>(response);
        }

        private IRestResponse RequestWithJsonBody(string endpoint, object content, Method method)
        {
            var request = new RestRequest(endpoint, method);

            request.AddJsonBody(content);
            return RestClient.Execute(request);
        }


        private IRestResponse RequestWithOutJsonBody(string endpoint, Method method)
        {
            var request = new RestRequest(endpoint, method);

            return RestClient.Execute(request);
        }

        private TResponse GetResponseContent<TResponse>(IRestResponse response) where TResponse : class
        {
            var byteArray = response.RawBytes;
            var responseString = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
            if (EnsureSuccessStatusCode(responseString, response))
                return JsonConvert.DeserializeObject<TResponse>(responseString);
            return null;
        }

        private bool EnsureSuccessStatusCode(string responseString, IRestResponse response)
        {
            if (response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.Continue)
            {
                var errorresponse =  JsonConvert.DeserializeObject<ErrorResponse>(responseString);
                this.AddNotification(errorresponse.Error.Type, errorresponse.Error.Message);
            }

            return this.IsValid();
        }
    }
}
