//ArMan DS
using ArManBank.Data;
using ArManBank.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArManBank.APIs
{
    public class ManageAccount
    {
        private readonly ArManBankDbContext _db;

        public ManageAccount()
        {
            _db = new ArManBankDbContext();
        }

        /// <summary>
        /// This method Add an User to Database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task AddToData(User? user)
        {
            ArgumentException.ThrowIfNullOrEmpty(nameof(user));


            await _db.AddAsync(user!);
            await _db.SaveChangesAsync();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Data Saved successful!");
            Console.ResetColor();
        }

        /// <summary>
        /// This method modify Database Data base on user input
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task ModifyData(User? user)
        {
            ArgumentException.ThrowIfNullOrEmpty(nameof(user));

            await _db.Users.Where(u => u.Id == user!.Id)
                .ExecuteUpdateAsync(set => set
                .SetProperty(p => p.Id, user!.Id)
                .SetProperty(p => p.FirstName, user.FirstName)
                .SetProperty(p => p.LastName, user.LastName)
                .SetProperty(p => p.Balance, user.Balance)
                .SetProperty(p => p.CreateDate, user.CreateDate)
                .SetProperty(p => p.TypeOfBalance, user.TypeOfBalance));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Data Modified successful!");
            Console.ResetColor();
        }

        /// <summary>
        /// This method Delete Special user from Database base on UserId input
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>

        public async Task DeleteData(int? userId = 0)
        {
            if(userId == 0 || userId is null) 
                throw new ArgumentNullException(nameof(userId));

            await _db.Users.Where(us => us.Id == userId).ExecuteDeleteAsync();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Data Deleted successful!");
            Console.ResetColor();
        }
    }
}
