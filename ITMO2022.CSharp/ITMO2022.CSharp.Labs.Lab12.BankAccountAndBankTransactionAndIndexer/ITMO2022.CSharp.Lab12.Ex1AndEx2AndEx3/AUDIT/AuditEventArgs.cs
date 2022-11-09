using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class AuditEventArgs : EventArgs
    {
        private readonly BankTransaction transData = null;

        public AuditEventArgs(BankTransaction transaction)
        {
            transData = transaction;
        }

        public BankTransaction GetTransaction()
        {
            return transData;
        }
    }
}
