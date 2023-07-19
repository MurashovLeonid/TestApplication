using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.UseCases.Queries.Users.DTO;

namespace TestApplication.UseCases.Queries.Users
{
    public class UsersPaginationQuery : IRequest<UsersPaginationResponse>
    {
        public UsersPaginationQuery(int limit, int offset, OrderField orderField, OrderType orderType, bool isPhotoDocRequested)
        {
            Limit = limit;
            Offset = offset;
            OrderType = orderType;
            OrderField = orderField;
            IsPhotoDocRequested = isPhotoDocRequested;
        }

        public int Limit { get; private set; }

        public int Offset { get; private set; }

        public OrderType OrderType { get; private set; }

        public OrderField OrderField { get; private set; }

        public bool IsPhotoDocRequested { get; private set; } = false;

    }
}
