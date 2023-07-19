using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApplication.UseCases.Queries.Users;
using TestApplication.UseCases.Queries.Users.DTO;

namespace TestApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        
        [HttpGet]
        public async Task<UsersPaginationResponse> GetUsersPaginationAsync([FromQuery] UsersPaginationRequestDto request)
        {
           return await _mediator.Send(new UsersPaginationQuery(request.Limit, request.Offset, request.OrderField, request.OrderType, request.IsPhotoDocRequested));
        }      
    }
}
