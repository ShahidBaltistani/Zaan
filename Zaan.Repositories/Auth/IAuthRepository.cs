using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zaan.Models.Model;
using Zaan.ViewModel.DTO;

namespace Zaan.Repositories.Auth
{
    public interface IAuthRepository
    {
        Task SignUpCustomer(SignUpDTO user);
        Task SignIn(User user);
    }
}
