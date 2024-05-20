using Application.Common.Interfaces;
using System;
using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Dto;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Application.Common.Models.Response<CustomerDto>> CreateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<Application.Common.Models.Response<CustomerDto>> GetCustomerByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Application.Common.Models.Response<CustomerDto>> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
