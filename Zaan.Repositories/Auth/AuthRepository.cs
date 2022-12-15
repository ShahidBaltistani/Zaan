using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaan.Models;
using Zaan.Models.Model;
using Zaan.ViewModel.DTO;

namespace Zaan.Repositories.Auth
{
    public class AuthRepository  : IAuthRepository
    {
        private readonly ZaanContext zaanContext;
        public AuthRepository(ZaanContext _zaanContext)
        {
            zaanContext= _zaanContext;
        }

        public async Task SignIn(User user)
        {
        }

        public async Task SignUpCustomer(SignUpDTO user)
        {
            if (user != null)
            {
                Customer customer = new Customer()
                {
                    Name = user.Name,
                    Email = user.Email,
                    Phone = user.Phone,
                    Address = user.Address,
                    IsActive = true,
                    UserName = user.UserName,
                    Password = user.Password,
                    RoleId= user.RoleId,
                };
               await zaanContext.Customers.AddAsync(customer);
                await   zaanContext.SaveChangesAsync();
            }
        }

     
    }
}
