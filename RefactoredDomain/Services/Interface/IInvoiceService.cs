using RefactoredPersistence.Entities;

namespace RefactoredDomain.Services.Interface
{
    public interface IInvoiceService
    {
        public string ProcessPayment(Payment payment);
    }
}