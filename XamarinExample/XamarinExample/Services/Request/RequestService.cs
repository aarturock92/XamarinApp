using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Threading.Tasks;

namespace XamarinExample.Services.Request
{
    public class RequestService : IRequestService
    {
        private readonly JsonSerializerSettings _serializerSettings;

        public RequestService()
        {
            _serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        public Task<TResult> GetAsync<TResult>(string uri, string token = "")
        {
            throw new NotImplementedException();
        }

        public Task<TResult> PostAsync<TResult>(string uri, TResult data, string token = "")
        {
            throw new NotImplementedException();
        }

        public Task<TResult> PostAsync<TRequest, TResult>(string uri, TRequest data, string token = "")
        {
            throw new NotImplementedException();
        }

        public Task<TResult> PutAsync<TResult>(string uri, TResult data, string token = "")
        {
            throw new NotImplementedException();
        }

        public Task<TResult> PutAsync<TResult, TRequest>(string uri, TRequest data, string token = "")
        {
            throw new NotImplementedException();
        }

        //private bool IsEmail(string email)
        //{
        //    return new EmailAddressAttribute().IsValid(email);
        //}
    }
}
