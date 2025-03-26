using Microsoft.EntityFrameworkCore;

namespace AppDevGCD2501.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
