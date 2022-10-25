using DynamicApi.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Traveler.Models; 

public class ApplicationDbContext : DynamicContext{

    public ApplicationDbContext(DbContextOptions options) : base(options) {
    }
    
    
}