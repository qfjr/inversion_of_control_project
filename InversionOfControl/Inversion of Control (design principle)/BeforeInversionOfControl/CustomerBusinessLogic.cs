using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl.Inversion_of_Control__design_principle_.BeforeInversionOfControl
{
    public class CustomerBusinessLogic
    {
        DataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
            _dataAccess = new DataAccess(); // here the CustomerBusinessLogic class depeneds on the DataAccess class and creates an object here (tightly coupled)

            // Problems with the above design 
            //===============================
            // 1. Changes in the DataAccess class will lead to changes in the CustomerBusinessLogic class, for example if we add, remove or rename any method
            // we need to hange the CustomerBusinessLogic class accordingly
            // 2. If th customer data comes from a different database or web service, we may need to create different classes, so this will lead to changes in the CustomerBusinessLogic
            // 3. The CustomerBusinessLogic class create a DataAccess object using the NEW keyword. There may be multiple classes using the DataAccess class, so if we change its name 
            // then you need to find all the places in your source code where we created objects of DataAccess and make the changes
            // 4. Because the CustomerBusinessLogic class creates an object of the concrete DataAccess class, it cannot be tested independently
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    public class DataAccess
    {
        public DataAccess()
        {

        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // Get it from DB in real app
        }
    }


}
