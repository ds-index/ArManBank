//ArMan DS
using ArManBank.Data;
using ArManBank.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArManBank.APIs
{
    public class RetrieveData
    {
        private readonly ArManBankDbContext _db;

        public RetrieveData()
        {
            _db = new ArManBankDbContext();
        }

        public async Task<List<User>> Data()
        {
            if(!_db.Users.Any())
                ArgumentException.ThrowIfNullOrEmpty(nameof(_db.Users));

            return await _db.Users.ToListAsync();
        }
    }
}
