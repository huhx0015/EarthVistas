using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace EarthVistas
{
    public interface RetrofitInterface
    {
        [Get("/r/EarthPorn/.json")]
        Task<RootObject> ListVistas();
    }
}