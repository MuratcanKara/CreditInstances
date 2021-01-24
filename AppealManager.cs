using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        
        //method injection
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //HousingLoanManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculate();

            // bağımsız kredi
            creditManager.Calculate();
            
        
        }
    
    
        public void Creditİnformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }


    }
}
