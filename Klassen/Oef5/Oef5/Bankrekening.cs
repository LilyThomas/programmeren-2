using System;
namespace Oef5
{
    public class Bankrekening
    {
		private const double YEARLY_INTEREST = 0.0125;
		private double balance;
        private string bankaccountNr;
        private DateTime registryDate;

        public Bankrekening(string bankaccountNr, double balance, DateTime regestryDate)
        {

        }

        public double BankaccountNr
        {
            get;
            set;
        }

        public double Balance
        {
            get;
            set;
        }

        public DateTime RegistryDate
        {
            get
            {
                return registryDate;
            }
            set
            {
                if(value > DateTime.Today)
                {
                    registryDate = DateTime.Today; 
                }
                else
                {
                    registryDate = value;
                }
            }
        }

        public double CheckBankAccount()
        {
            if(this.registryDate.Year != DateTime.Today.Year)
            {
                
            }
        }

        public void AddToAccount(double value)
        {
            this.balance += value;
        }

        public void WithdrawFromAccount(double value)
        {
            if(value < this.balance)
            {
                this.balance -= value;
            }
        }


    }
}
