using System.Collections.Generic;
using MediatR;

namespace Trakr.Api.Features.Values
{
    public class GetValuesQuery: IRequest<IEnumerable<string>> { }
}