using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQSExplorer.Core.Interfaces
{
    public interface IQueueRepository
    {
        Task<List<Entidades.Queue>> ListAll();

        Task<Entidades.Queue> Get(string url);
    }
}
