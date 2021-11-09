using System;
using System.Collections.Generic;
using System.Text;

namespace SQSExplorer.Core.Entidades
{
   public class Message
    {
        public string Content { get; set; }
        public string Id { get; set; }
        public string QueueIdentifier { get; set; }
    }
}
