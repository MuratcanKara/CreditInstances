using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.MakeAnApplication(personalFinanceCreditManager, databaseLoggerService);
            


            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager , transportCreditManager};
            //appealManager.Creditİnformation(credits);

        }
    }
}
// İNTERFACE ONU İMPLEMENTE EDEN CLASS'IN REFERANSINI TUTABİLİR.