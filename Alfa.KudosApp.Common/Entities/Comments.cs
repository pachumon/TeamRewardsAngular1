using System;
using System.Collections.Generic;
using System.Text;

namespace Alfa.KudosApp.Common.Entities
{
    public class Comments
    {
        public int ReceiverId { get; set; }
        public string Comment { get; set; }
        public int ProviderId { get; set; }
        public string ReceiverName { get; set; }
        public string ProviderName { get; set; }
    }
}
