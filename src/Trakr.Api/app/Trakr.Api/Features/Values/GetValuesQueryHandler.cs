using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Trakr.Api.Features.Values
{
    public class GetValuesQueryHandler : IRequestHandler<GetValuesQuery, IEnumerable<string>>
    {
        public Task<IEnumerable<string>> Handle(GetValuesQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<string> values = new string[] {"value1", "value2"};
            return Task.FromResult(values);
        }
    }
}