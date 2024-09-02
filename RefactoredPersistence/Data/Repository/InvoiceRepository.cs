using RefactoredPersistence.Data.Repository.Interface;
using RefactoredPersistence.Entities;

namespace RefactoredPersistence.Data.Repository
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        private bool _bResult;
        private string _errMsg = string.Empty;

        public InvoiceRepository(AppDbContext context) : base(context)
        {
        }
    }
}