using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace EcoEnergyLiveFunctionApp
{
    public class EcoEnergyLiveFunctionApp
    {
        private readonly ILogger _logger;

        public EcoEnergyLiveFunctionApp(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<EcoEnergyLiveFunctionApp>();
        }

        [Function("EcoEnergyLiveFunctionApp")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Hi Scarstack Solution Inc. Welcome to Azure Functions!");

            return response;
        }

          [Function("EcoEnergyCampaignSuite")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Hi Scarstack Solution Inc. Welcome to Azure Functions!");

            return response;
        }
    }
}

