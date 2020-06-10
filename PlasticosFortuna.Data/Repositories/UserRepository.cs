using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PlasticosFortuna.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public UserModel GetLoginUser(UserModel user)
        {
            UserModel response = new UserModel();


            return _appDbContext.UserModel.Include("UserRole").FirstOrDefault(u => u.LoginId == user.LoginId && u.Password == user.Password);

            

    //        var query = context.Customers
    //.Join(
    //    context.Invoices,
    //    customer => customer.CustomerId,
    //    invoice => invoice.Customer.CustomerId,
    //    (customer, invoice) => new
    //    {
    //        InvoiceID = invoice.Id,
    //        CustomerName = customer.FirstName + "" + customer.LastName,
    //        InvoiceDate = invoice.Date
    //    }
    //).ToList();
        }
    }
}
