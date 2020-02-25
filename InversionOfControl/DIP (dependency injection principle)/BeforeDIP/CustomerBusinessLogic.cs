using System;
using System.Collections.Generic;
using System.Text;

namespace InversionOfControl.Inversion_of_Control__design_principle_.BeforeInversionOfControl
{
    class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {

        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

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

    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }


}
