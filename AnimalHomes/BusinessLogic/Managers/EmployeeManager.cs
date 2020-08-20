using DataAccess.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic.Managers
{
    public class EmployeeManager : UserManager<Employee>
    {
        public EmployeeManager(IUserStore<Employee> store) : base(store) { }

        public static EmployeeManager Create(IdentityFactoryOptions<EmployeeManager> options, IOwinContext context)
        {
            ContextAnimalHomes db = context.Get<ContextAnimalHomes>();
            EmployeeManager manager = new EmployeeManager(new UserStore<Employee>(db));
            return manager;
        }
    }
}
