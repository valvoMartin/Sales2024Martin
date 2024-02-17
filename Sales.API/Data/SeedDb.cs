using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {

            await _context.Database.EnsureCreatedAsync(); //update-database
            await CheckCountriesAsync(); 
        }


        /// <summary>
        /// Si no hay paises los crea
        /// </summary>
        /// <returns></returns>
        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Estados Unidos" });
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country { Name = "Mexico" });
            }

            await _context.SaveChangesAsync();
        }

    }
}
