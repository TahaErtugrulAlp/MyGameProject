using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerValidationService customerValidationService;

        public CustomerManager()
        {
        }

        public CustomerManager(ICustomerValidationService customerValidationService)
        {
            this.customerValidationService = customerValidationService;

        }

        public void Delete(Customer customer)
        {
            if (customerValidationService.ValidateCustomer(customer))
            {
                Console.WriteLine(customer.FirstName + "" + customer.LastName+",Kayıt başarılı");
            }
            else
            {
                throw new Exception("Kullanıcı doğrulaması başarısız. Kayıt olamadınız.");
            }


        }

        public void SignUp(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " +customer.LastName+", bilgileriniz güncellendi.");

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName+", Hesabınız başarıyla silinmiştir.");
        }
    }
}
