namespace Assignment3.Entities.PaymentMethods
{
    class BankTransfer : PaymetnMethod
    {
        //========================= Properties ========================================
        public override string Name { get; } = "Bank transfer";

        //========================= Methods ===========================================
        public override bool Pay(decimal amount)
        {
            if (amount <= 0) return false;
            else return true;
        }
    }
}
