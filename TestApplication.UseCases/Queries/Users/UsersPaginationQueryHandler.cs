using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;

using System.Threading.Tasks;
using TestApplication.Infrastructure.EFCore.Context;
using TestApplication.UseCases.Queries.Users.DTO;

namespace TestApplication.UseCases.Queries.Users
{
    public class UsersPaginationQueryHandler : IRequestHandler<UsersPaginationQuery, UsersPaginationResponse>
    {
        private readonly ApplicationDbContext _context;
        public UsersPaginationQueryHandler(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<UsersPaginationResponse> Handle(UsersPaginationQuery request, CancellationToken cancellationToken)
        {
            var usersQuery = _context.ApplicationUsers.AsNoTracking();

            usersQuery = request.OrderField == OrderField.FIO
                ? (request.OrderType == OrderType.Asc ? usersQuery.OrderBy(x => x.FullName) : usersQuery.OrderByDescending(x => x.FullName))
                : (request.OrderType == OrderType.Asc ? usersQuery.OrderBy(x => x.BirthDate) : usersQuery.OrderByDescending(x => x.BirthDate));

            if (request.IsPhotoDocRequested)
            {
                usersQuery = usersQuery.Include(x => x.UserPhoto);
            }
            usersQuery = usersQuery.Skip(request.Offset).Take(request.Limit);

            var result = new UsersPaginationResponse()
            {
                Users = await usersQuery.Select(x => new UserDto(x.FullName, (request.IsPhotoDocRequested) ? x.UserPhoto.Photo : null, x.BirthDate, x.PhotoUri)).ToListAsync(),
                PaginationData = new PaginationData(request.Limit, request.Offset, await usersQuery.CountAsync())
            };
            return result;
        }


    }
}
