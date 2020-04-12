namespace Assignment3.Entities.PaymentMethods
{
    class Credit_DebitCard : PaymetnMethod
    {
        //========================= Properties ========================================
        public override string Name { get; } = "Credit - Debit card";

        //========================= Methods ===========================================
        public override bool Pay(decimal amount)
        {
            if (amount <= 0 || amount > 600) return false;
            else return true;
        }
    }
}
