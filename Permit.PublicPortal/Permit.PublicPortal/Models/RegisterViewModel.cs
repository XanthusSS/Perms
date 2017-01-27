using Permits.DataAccess.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Permit.PublicPortal
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
           User = new UserSignUpView();
           Car = new List<CarViewModel>();
        }
        public UserSignUpView User { get; set; }

        public List<CarViewModel> Car { get; set; }
    }
}