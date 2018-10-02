﻿
using System.Collections.Generic;
using System.Text;

namespace Oprava.Services
{
    //Consumo de servicios Rest base datos
    using System;
    using Oprava.Common.Models;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Newtonsoft.Json;

    public   class ApiService 
    {
      public async Task <Response> GetList<T>(string urlBase, string prefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = $"{prefix}{controller}";
                var response = await client.GetAsync(url);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSucces = false,
                        Message = answer,
                    };
                }
                var list = JsonConvert.DeserializeObject<List<T>>(answer);
                return new Response
                {
                    IsSucces = true,
                    Result = list,
                };
            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSucces=false,
                    Message=ex.Message,
                };
            }
        }
    }
}
