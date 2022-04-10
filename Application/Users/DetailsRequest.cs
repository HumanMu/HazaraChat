using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Users
{
    public class DetailsRequest
    {
        public class Query : IRequest<User> 
        {
            public int Id {get; set;} 

         }
        public class Handler : IRequestHandler<Query, User>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }


            public async Task<User> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FindAsync(request.Id);    // FindAsync, since we return only ONE user
                return user; 
            }
        }
    }
}