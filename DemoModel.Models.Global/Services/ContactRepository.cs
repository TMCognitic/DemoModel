using DemoModel.Api.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace DemoModel.Models.Global.Services
{
    public class ContactRepository : IContactRepository<Contact>
    {
        public IEnumerable<Contact> Get()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:5001/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Contact").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Contact[]>(json);
            }
        }

        public Contact Get(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:5001/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Contact/"+id).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Contact>(json);
            }
        }

        public Contact Insert(Contact entity)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:5001/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(entity);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync("Contact", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Contact>(json);
            }
        }
    }
}
