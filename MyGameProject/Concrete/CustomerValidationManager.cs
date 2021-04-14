using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    public class CustomerValidationManager : ICustomerValidationService
    {
        public bool ValidateCustomer(Customer customer)
        {
            if (customer.FirstName.Equals("Ertuğrul") && customer.LastName.Equals("Alp") 
                && customer.IdentityNumber.Equals("485645342342") && customer.DateOfBirth.Equals(2002))
            {
                return true;

            }
            else
            {
                return false;
            }
            

        }
    }
}
