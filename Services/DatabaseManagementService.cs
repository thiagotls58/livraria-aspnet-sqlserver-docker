using livraria.Data;
using Microsoft.EntityFrameworkCore;

namespace livraria.Services;

public static class DatabaseManagementService
{
    public static void MigrationInitialization(this IApplicationBuilder app) 
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            var serviceDb = serviceScope.ServiceProvider.GetService<AppDbContext>();
            
            serviceDb.Database.Migrate(); // aplica as migrações que ainda não foram aplicadas na base de dados
        }
    }
}