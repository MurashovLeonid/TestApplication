using System.Collections.Generic;
using TestApplication.UseCases.Queries.Users.DTO;

namespace TestApplication.UseCases.Queries.Users
{
    public class UsersPaginationResponse
    {
        public List<UserDto> Users { get; set; }

        public PaginationData PaginationData { get; set; }
    }
}
