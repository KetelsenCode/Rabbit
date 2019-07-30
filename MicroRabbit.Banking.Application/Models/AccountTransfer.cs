using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int ToAccount { get; set; }
        public int FromAccount { get; set; }
        public decimal Amount { get; set; }
    }
}
