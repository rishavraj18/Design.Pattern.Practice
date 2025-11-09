using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Singelton.Design.Pattern.Services
{
    public class ProductCacheService : IProductCacheService
    {
        private readonly IMemoryCache _cache;
        private readonly ILogger<ProductCacheService> _logger;
        private const string CacheKey = "products_list";

        public ProductCacheService(IMemoryCache cache, ILogger<ProductCacheService> logger)
        {
            _cache = cache;
            _logger = logger;
        }

        public IEnumerable<string> GetProducts()
        {
            if (_cache.TryGetValue(CacheKey, out IEnumerable<string> products))
            {
                _logger.LogInformation("✅ Returning products from cache at {time}", DateTime.Now);
                return products;
            }

            // Simulate data fetching (e.g., from DB or API)
            products = new List<string> { "Laptop", "Tablet", "Smartphone", "Headphones" };
            _logger.LogInformation("🆕 Fetched products from database at {time}", DateTime.Now);

            // Store in cache for 5 minute
            _cache.Set(CacheKey, products, TimeSpan.FromMinutes(5));


            //Item expires if not used for 5 minutes
            //Or after 30 minutes total, whichever comes first

            //var options = new MemoryCacheEntryOptions
            //{
            //    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30),
            //    SlidingExpiration = TimeSpan.FromMinutes(5)
            //};
            //_cache.Set("products_list", data, options);

            //Use Cases of caching

            //Use Case                     Example Duration       Notes
            //App Config Data              12 hours               Changes rarely
            //Product List                 10 minutes             Updated by admin occasionally
            //Currency Exchange Rates      15 minutes             Reasonably up - to - date
            //User Dashboard Summary        2 minutes             Personalized, quick refresh
            //Stock Prices / Live Scores   15–30 seconds          Must stay near real - time
            //Geo lookup / Weather API     30–60 minutes          Data not volatile

            return products;
        }
    }
}
