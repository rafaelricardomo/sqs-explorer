using SQSExplorer.Core.Entidades;
using SQSExplorer.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Core.Serviços
{
    public class QueueService : IQueueService
    {
        private readonly IQueueRepository _queueRepository;

        public QueueService(IQueueRepository queueRepository)
        {
            _queueRepository = queueRepository;
        }

        public async Task<Queue> Get(string url)
        {
            return await _queueRepository.Get(url);
        }

        public async Task<List<Queue>> ListAll()
        {
            return await _queueRepository.ListAll();
        }
    }
}
