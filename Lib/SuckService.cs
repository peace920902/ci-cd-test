using Lazcat.Infrastructure.DependencyInjection;

namespace Lib
{
    [DependencyInjection(typeof(ISuckService))]
    public class SuckService : ISuckService
    {
        public string SuckMyDick()
        {
            return "Suck My Dick Man";
        }
    }
}