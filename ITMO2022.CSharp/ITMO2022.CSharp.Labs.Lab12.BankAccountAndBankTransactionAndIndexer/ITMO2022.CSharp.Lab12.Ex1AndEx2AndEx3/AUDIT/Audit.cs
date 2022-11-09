using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Banking
{
    public class Audit
    {
        private string filename;
        private StreamWriter auditFile;
        private bool closed = false;

        public Audit(string fileToUse)
        {
            filename = fileToUse;
            auditFile = File.AppendText(fileToUse);
        }

        public void RecordTransaction(object sender, AuditEventArgs eventData)
        {
            BankTransaction tempTrans = eventData.GetTransaction();

            if (tempTrans != null)
                auditFile.WriteLine("Amount: {0}\tDate: {1}", tempTrans.Amount(), tempTrans.When()); 
        }

        public void Close()
        {
            if (!closed)
            {
                auditFile.Close();
                closed = true;
            }
        }
    }
}
