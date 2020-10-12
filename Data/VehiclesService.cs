using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

        //public Task<List<Vehicles>> GetVehiclesAsync()
        //{
        //    return _context?.Vehicles.ToListAsync();
        //}
    }
}
//return Task.FromResult(index => new Vehicles
//{
//Year = index.Year,
//Make = index.Make,
//Model = index.Model,
//Color = index.Color
//}).ToArray<Vehicles>();

//var rng = new Random();
//return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
//{
//    Date = startDate.AddDays(index),
//    TemperatureC = rng.Next(-20, 55),
//    Summary = Summaries[rng.Next(Summaries.Length)]
//}).ToArray());