using RefactoredPersistence.Data.Repository.Interface;
using RefactoredPersistence.Entities;

namespace RefactoredPersistence.Data.Repository
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
        }
    }
}