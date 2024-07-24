using Microsoft.EntityFrameworkCore;

namespace LSC.ResterauntTableBookingApp.Data
{
    public class RestaurantTableBookingDbContext:DbContext
    {
        public RestaurantTableBookingDbContext(DbContextOptions<RestaurantTableBookingDbContext> options): base(options)
        {
            
        }
    }
}
