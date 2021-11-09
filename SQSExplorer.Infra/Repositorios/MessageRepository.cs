using Amazon.SQS;
using Amazon.SQS.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SQSExplorer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Infra.Repositorios
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ILogger<MessageRepository> _logger;
        private readonly IConfiguration _configuration;

        public MessageRepository(
            ILogger<MessageRepository> logger, IConfiguration configuration
        )
        {
            _logger = logger;
            _configuration = configuration;
        }

        

        public async Task<bool> SendMessage(string message, string queueName)
        {
            var sended = false;
            var queueUrl = GetQueueUrl(queueName);

            try
            {
                using (var client = GetSQSClient())
                {
                    var response = await client.SendMessageAsync(
                                                    new SendMessageRequest
                                                    {
                                                        QueueUrl = queueUrl,
                                                        MessageBody = message
                                                    });
                    
                    sended = response.HttpStatusCode == System.Net.HttpStatusCode.OK;
                }

                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return sended;
        }

        public async Task<Core.Entidades.Message> GetMessage(string queueName)
        {
            try
            {
                var queueUrl = GetQueueUrl(queueName);

                using var sqsClient = GetSQSClient();
                var request = new ReceiveMessageRequest()
                {
                    MaxNumberOfMessages = 1,                   
                    QueueUrl = queueUrl
                };

                var response = await sqsClient.ReceiveMessageAsync(request);

                return response?.Messages?.Select(message => MapMessage(message))
                        .DefaultIfEmpty(null)
                        .FirstOrDefault();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
        }

        public async Task<bool> DeleteMessage(string identifier, string queueName)
        {
            try
            {
                var queueUrl = GetQueueUrl(queueName);
                using var sqsClient = GetSQSClient();
                var response = await sqsClient.DeleteMessageAsync(queueUrl, identifier);

                return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }


        private Core.Entidades.Message MapMessage(Message message)
        {
            return new Core.Entidades.Message { 
                Id = message.MessageId, 
                QueueIdentifier = message.ReceiptHandle, 
                Content = message.Body 
            };
        }

        private string GetQueueUrl(string queueName)
        {
            return $"{_configuration.GetSection("AWS_SQS:QueuePath").Value}/{_configuration.GetSection("AWS_SQS:QueueUser").Value}/{queueName}"; ;
        }

        private IAmazonSQS GetSQSClient()
           => new AmazonSQSClient(
                   _configuration.GetSection("AWS_SQS:AccessKeyID").Value,
                   _configuration.GetSection("AWS_SQS:SecretAccessKey").Value,
                   new AmazonSQSConfig { ServiceURL = _configuration.GetSection("AWS_SQS:QueuePath").Value }
               );


        
    }
}
