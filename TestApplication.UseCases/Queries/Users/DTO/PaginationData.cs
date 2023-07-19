using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UseCases.Queries.Users.DTO
{
    public struct PaginationData
    {
        public int Limit { get; private set; }
        public int Offset { get; private set; }
        public int Total { get; private set; }

        public PaginationData(int limit, int offset, int total)
        {
            Limit = limit;
            Offset = offset;
            Total = total;
        }
    }
}
