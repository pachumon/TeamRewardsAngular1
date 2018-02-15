using System;
using System.Collections.Generic;
using System.Text;

namespace Alfa.KudosApp.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KudosCount { get; set; }
        public bool IsUpdated { get; set; }
    }
}
