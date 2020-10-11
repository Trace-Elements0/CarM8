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

        /*public async Task<Vehicles> GetHelpDeskTicketAsync(string HelpDeskTicketGuid)
        { 
            // Get the existing record.
            var ExistingVehicels = await _context.Vehicles 
                .Include(x => x.Profiles) 
                .Where(x => x.TicketGuid == HelpDeskTicketGuid) 
                .AsNoTracking() .FirstOrDefaultAsync(); 
            return ExistingTicket;
        } */
        //public Task<HelpDeskTickets> CreateTicketAsync(HelpDeskTickets newHelpDeskTickets);
    }
}
