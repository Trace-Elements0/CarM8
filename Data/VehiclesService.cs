using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace main_CarM8.Data
{
    public class VehiclesService
    {
        private readonly Carm8DataContext _context;

        public VehiclesService(Carm8DataContext context)
        {
            _context = context;
        }

        public IQueryable<Vehicles> GetVehicles()
        {
            return _context.Vehicles.AsNoTracking();
        }
    }
}