using EmployesAdmin.Dto;
using Newtonsoft.Json;
using Spring.Http;
using Spring.Http.Client;
using Spring.Http.Converters.Json;
using Spring.Rest.Client;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployesAdmin.DT
{
    public static class EmployesServiceClient
    {

        private const string employesDataMethod = "/Employees/ApiEmployeesGet";


        public static IEnumerable<Employe> GetAllEmployes()
        {
            string autenticacion = string.Empty;
            HttpResponseMessage<string> respuesta;
            HttpHeaders encabezado = new HttpHeaders();
            RestTemplate marco = new RestTemplate();
            HttpEntity entidadEntrada = new HttpEntity();

            IEnumerable<Employe> employes;
            marco = PrepararMarcoServicio();

            respuesta = marco.GetForMessage<string>(DataResources.EmployesData);
            employes = JsonConvert.DeserializeObject<IEnumerable<Employe>>(respuesta.Body);
            return employes;
        }


        private static RestTemplate PrepararMarcoServicio()
        {
            RestTemplate marco = new RestTemplate(DataResources.EmployesData);
            marco.MessageConverters.Add(new DataContractJsonHttpMessageConverter());
            WebClientHttpRequestFactory requestFactory = new WebClientHttpRequestFactory();
            requestFactory.Timeout = 1000000;
            marco.RequestFactory = requestFactory;

            return marco;
        }

    }
}
