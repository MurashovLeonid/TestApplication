using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UseCases.Queries.Users.DTO
{
    public class UsersPaginationRequestDto
    {
        public int Limit { get; set; } = 10;

        public int Offset { get; set; } = 0;

        public OrderField OrderField { get; set; } = OrderField.DateBirth;
        public OrderType OrderType { get; set; } = OrderType.Asc;
        public bool IsPhotoDocRequested { get; private set; } = false;

    }
}
