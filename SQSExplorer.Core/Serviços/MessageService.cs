using SQSExplorer.Core.Entidades;
using SQSExplorer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Core.Serviços
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<bool> DeleteMessage(string identifier, string queueName)
        {
            return await _messageRepository.DeleteMessage(identifier, queueName);
        }

        public async Task<Message> GetMessage(string queueName)
        {
            return await _messageRepository.GetMessage(queueName);
        }

        public async Task<bool> SendMessage(string message, string queueName)
        {
            return await _messageRepository.SendMessage(message, queueName);
        }
    }
}
