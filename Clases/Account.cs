using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja.Clases
{
    public class Account
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Number { get; set; }
        public int OwnerId { get; set; }
        public int AccountTypeId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? LastTransation { get; set; }
        public int? AccountManagerId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public int? StatusId { get; set; }
        public double Balance { get; set; }

        public void IncreaseBalance(double amount)
        {
            Balance += amount;
        }

        public void DecreaseBalance(double amount)
        {
            Balance -= amount;
        }
    }
}
