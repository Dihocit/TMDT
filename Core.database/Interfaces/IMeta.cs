using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.database.Interfaces
{
    public interface  IMeta
    {
        public string? Keyword { get; set;  }
        public string? Description { get; set; }
    }
}
