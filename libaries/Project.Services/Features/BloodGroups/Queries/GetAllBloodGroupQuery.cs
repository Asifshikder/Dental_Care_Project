using MediatR;
using Microsoft.EntityFrameworkCore;
using Project.Core.Domain.Common;
using Project.Infrastructure;
using Project.Infrastructure.Data;
using Project.Infrastructure.DataAccess;
using Project.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Features.BloodGroups.Queries
{
    public class GetAllBloodGroupQuery : IRequest<IEnumerable<BloodGroup>>
    {
        public class GetAllBloodGroupQueryHandler : IRequestHandler<GetAllBloodGroupQuery, IEnumerable<BloodGroup>>
        {
            //private readonly IApplicationDbContext repository;
            private ISqlService _service;
            public GetAllBloodGroupQueryHandler(/*IApplicationDbContext repository,*/ ISqlService service)
            {
                //this.repository = repository;
                _service = service;
            }
            public async Task<IEnumerable<BloodGroup>> Handle(GetAllBloodGroupQuery request, CancellationToken cancellationToken)
            {
                //var res = await _service.ExecuteAsync<IEnumerable<BloodGroup>>("select * from BloodGroups", new { });
                var res = await _service.ExecuteAsync<BloodGroup, dynamic>(query: "select * from BloodGroups", new { });
                return res;
            }
        }
    }
}
