using System.Data;
using System.Transactions;

namespace GAF.API.Repositories.Interfaces;
public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllByUserIdAsync(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(string userId, DataSetDateTime startDate, DataSetDateTime endDate);
    Task<IEnumerable<Transaction>> GetByCategoryAsync(string userId, int categoryId);
    Task<Transaction> CreateAsync(Transaction transaction);
    Task<Transaction> UpdateAsync(Transaction transaction);
    Task<bool> DeleteAsync(int id, string userId);
    Task<decimal> GetTotalIncomeByMonthAsync( string userId, int month, int year);
    Task<decimal> GetTotalExpensesByMonthAsync(string userId, int month, int year);
    Task<IEnumerable<Transaction>> GetRecentTransactionAsync(string userId, int count = 10);
}
