using System;

namespace Banking2x.Models.Domain
{
    public class BankAccount
    {
        //private string _accountNumber;
        //public const decimal WithdrawCost = 0.10M; //constante met hoofdletter (en is sws static)

        #region Fields
        public static readonly decimal _withdrawCost = 0.10M; //readonly declaren hier of in constructor (indien static altijd hier)

        private decimal _balance;
        #endregion

        #region Properties
        public decimal Balance
        {
            get

            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Balance cannot be negative");
                _balance = value;
            }
        }

        public string AccountNumber { get; private set; }
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount/*, int nrOfTimes = 1*/) //eerst verplichte parameters, dan optionele(die default waarde hebben
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative");
            }
            Balance += amount /** nrOfTimes*/;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        } 
        #endregion


    }
}
