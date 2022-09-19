using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }

    }
}
