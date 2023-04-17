using MediatR;
using Project.Core.Domain.Common;
using Project.Infrastructure;
using Project.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Features.BloodGroups.Queries
{
    public class GetBloodGroupQuery : IRequest<BloodGroup>
    {
        public int Id { get; set; }

        public class GetBloodGroupQueryHandler : IRequestHandler<GetBloodGroupQuery, BloodGroup>
        {
            private readonly IRepository<BloodGroup> sqlService;

            public GetBloodGroupQueryHandler(IRepository<BloodGroup> sqlService)
            {
                this.sqlService = sqlService;
            }
            public async Task<BloodGroup> Handle(GetBloodGroupQuery request, CancellationToken cancellationToken)
            {
                var res = sqlService.Find(s => s.Id == request.Id).FirstOrDefault();
                return res;
            }
        }
    }
}
