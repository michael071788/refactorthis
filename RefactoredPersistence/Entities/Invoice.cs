﻿using static RefactoredPersistence.Enums.CommonEnum;

namespace RefactoredPersistence.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal TaxAmount { get; set; }
        public List<Payment>? Payments { get; set; }

        public InvoiceType Type { get; set; }
    }
}