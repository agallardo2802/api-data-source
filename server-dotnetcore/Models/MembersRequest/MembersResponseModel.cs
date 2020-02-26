using NetCoreServer.Models;
using System.Collections.Generic;

namespace NetCoreServer.Models.Members
{
    public class MembersResponse<T>
    {
        public MembersResponse()
        {
            Members = new List<T>();
        }

        public List<T> Members { get; set; }

        public bool Sorted { get; set; }

        public int Page { get; set; }

        public int PageTotal { get; set; }
    }
}