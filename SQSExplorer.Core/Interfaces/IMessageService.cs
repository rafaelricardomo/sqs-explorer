using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Core.Interfaces
{
    public interface IMessageService
    {
        Task<bool> SendMessage(string message, string queueName);
        Task<Core.Entidades.Message> GetMessage(string queueName);
        Task<bool> DeleteMessage(string identifier, string queueName);
    }
}
