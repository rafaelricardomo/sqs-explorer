using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SQSExplorer.Core.Entidades;
using SQSExplorer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Infra.Repositorios
{
   public  class QueueRepository : IQueueRepository
    {
        private readonly ILogger<QueueRepository> _logger;
        private readonly IConfiguration _configuration;

        public QueueRepository(
            ILogger<QueueRepository> logger, IConfiguration configuration
        )
        {
            _logger = logger;
            _configuration = configuration;
        }
       
        private async Task<List<Queue>> GetQueues(IAmazonSQS sqsClient)
        {
            var queues = new List<Queue>();
            ListQueuesResponse responseList = await sqsClient.ListQueuesAsync("");
            
            foreach (string qUrl in responseList.QueueUrls)
            {
                var queue = new Queue()
                {
                    Url = qUrl
                };                
                queues.Add(queue);
            }

            return queues;
        }

      
        private async Task<Queue> GetAllAttributes(IAmazonSQS sqsClient, string url)
        {
            try
            {
                var responseGet = await sqsClient.GetQueueUrlAsync(url);
                if (responseGet == null) return null; 

                var attributes = new List<string> { QueueAttributeName.All };
                GetQueueAttributesResponse responseGetAtt =
                  await sqsClient.GetQueueAttributesAsync(responseGet.QueueUrl, attributes);

                var especificacoes = responseGetAtt.Attributes;

                return new Queue()
                {
                    Url = url,
                    Especificacoes = especificacoes
                };
            }
            catch (Amazon.SQS.Model.QueueDoesNotExistException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Queue>> ListAll()
        {
            using (var client = GetSQSClient())
            {
                return await GetQueues(client);
            }
        }

        public async Task<Queue> Get(string url)
        {
            using (var client = GetSQSClient())
            {                
                return await GetAllAttributes(client, url);
            }
        }

        private IAmazonSQS GetSQSClient()
        => new AmazonSQSClient(
                _configuration.GetSection("AWS_SQS:AccessKeyID").Value,
                _configuration.GetSection("AWS_SQS:SecretAccessKey").Value,
                new AmazonSQSConfig { ServiceURL = _configuration.GetSection("AWS_SQS:QueuePath").Value }
            );
    }
}
