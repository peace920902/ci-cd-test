using System.Runtime.CompilerServices;
using Lazcat.Infrastructure.DependencyInjection;

namespace Lib
{
    [DependencyInjection(typeof(ICalService))]
    public class CalService : ICalService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}