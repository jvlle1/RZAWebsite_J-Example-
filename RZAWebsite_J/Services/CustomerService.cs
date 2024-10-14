using RZAWebsite_J.Models;
using Microsoft.EntityFrameworkCore;


namespace RZAWebsite_J.Services
{
    public class CustomerService
    {
        private readonly TlS2302721RzaContext _context;

        public CustomerService(TlS2302721RzaContext context)
        {
            _context = context;
        }

    }
}
