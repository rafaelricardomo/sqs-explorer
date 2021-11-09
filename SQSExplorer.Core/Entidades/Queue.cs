using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQSExplorer.Core.Entidades
{
    public class Queue
    {
        public string Name => Url.Split("/")?.LastOrDefault();
        public string Url { get; set; }
        public Dictionary<string, string> Especificacoes { get; set; }
    }
}
