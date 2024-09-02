using RefactoredPersistence.Data.Repository.Interface;
using RefactoredPersistence.Entities;

namespace RefactoredPersistence.Data.Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        private bool _bResult;
        private string _errMsg = string.Empty;

        public PaymentRepository(AppDbContext context) : base(context)
        {
        }
    }
}